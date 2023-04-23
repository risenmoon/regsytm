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
            string ConnectionString = "Data Source=DESKTOP-UBBFG4S\\SQLEXPRESS01;Initial Catalog=HIS;Integrated Security=True";
            string sqlstr = "select orgname from orgdict where orgtypeid=2";//选择临床科室，要注意科室类型
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlstr, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            orgid.Items.Add(reader.GetString(0));
                        }
                    }
                    else
                    {
                        MessageBox.Show("请维护科室");
                    }
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UBBFG4S\\SQLEXPRESS01;Initial Catalog=HIS;Integrated Security=True";
            string sqlstr = "insert into patioutvisit(CardNo,RegDate,RegOrg,RegEmp,SerialNumber) values('" + txtCardNo + "','" + regdate + "','" + orgid + "','" + empid + "','" + serialnumber + "')";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlstr, connection);
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("挂号成功，请及时就诊！");
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
                    string selectSql = "SELECT PatiName FROM patiinfo WHERE CardNo = @cardNo";
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
    }
}
