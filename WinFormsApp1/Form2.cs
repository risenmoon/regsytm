using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UBBFG4S\\SQLEXPRESS01;Initial Catalog=HIS;Integrated Security=True";
            string sqlstr = "SELECT orgname FROM orgdict WHERE orgtypeid=2"; //选择临床科室，要注意科室类型
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString)) //使用连接字符串创建SqlConnection对象
                {
                    SqlCommand cmd = new SqlCommand(sqlstr, conn); //创建SqlCommand对象
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); //创建SqlDataAdapter对象
                    adapter.Fill(ds); //填充DataSet对象
                }

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        orgid.Items.Add(ds.Tables[0].Rows[i][0]);
                    }
                }
                else
                {
                    MessageBox.Show("请维护科室");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UBBFG4S\\SQLEXPRESS01;Initial Catalog=HIS;Integrated Security=True";
            string sqlstr = "insert into patioutvisit(CardNo,RegDate,RegOrg,RegEmp,SerialNumber) values(@CardNo, @RegDate, @RegOrg, @RegEmp, @SerialNumber)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlstr, connection);
                    command.Parameters.Add("@CardNo", SqlDbType.VarChar).Value = txtCardNo.Text;
                    command.Parameters.Add("@RegDate", SqlDbType.DateTime).Value = regdate.Value;
                    command.Parameters.Add("@RegOrg", SqlDbType.VarChar).Value = orgid.SelectedItem.ToString();
                    command.Parameters.Add("@RegEmp", SqlDbType.VarChar).Value = empid.SelectedItem.ToString();
                    command.Parameters.Add("@SerialNumber", SqlDbType.VarChar).Value = orgtypeid.SelectedItem.ToString();

                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("挂号成功，请及时就诊！");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 获取输入的就诊卡号
            string cardNo = txtCardNo.Text;
            string connectionString = "Data Source=DESKTOP-UBBFG4S\\SQLEXPRESS01;Initial Catalog=HIS;Integrated Security=True";
            try
            {
                // 建立连接
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 查询病人信息
                    string selectSql = "SELECT PatiName FROM PatientsInfo WHERE CardNo = @cardNo";
                    SqlCommand command = new SqlCommand(selectSql, connection);
                    command.Parameters.AddWithValue("@cardNo", cardNo);
                    object result = command.ExecuteScalar();

                    // 将查询结果输出到Label控件
                    if (result != null)
                    {
                        lblPatiName.Text = result.ToString();
                    }
                    else
                    {
                        lblPatiName.Text = "未找到病人信息";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void regdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
