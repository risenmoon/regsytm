using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;


namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
            string mystr = "Data Source=DESKTOP-UBBFG4S\\SQLEXPRESS01;Initial Catalog=HIS;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(mystr))
            {
                con.ConnectionString = mystr;
                string sql = "select * fromHIS.dbo.PatientInfo";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    //建立SqlDataAdapter和DataSet对象
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();//数据再内存中的缓存
                    sda.Fill(ds, "sqlexpress01.HIS.dbo");
                    Console.WriteLine(ds);
                    //这里一定要注意是用DataSet集合中的表格来填充dataGridView
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();//关闭数据库连接
                    con.Dispose(); //释放资源

                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            // 创建连接字符串
            string connectionString = "Data Source=DESKTOP-UBBFG4S\\SQLEXPRESS01;Initial Catalog=HIS;Integrated Security=True";

            // 创建查询语句
            string query = "SELECT * FROM patientsInfo";

            // 创建数据适配器和数据集
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();

                // 填充数据集
                adapter.Fill(dataSet, "patientsInfo");

                // 绑定数据集到 DataGridView
                dataGridView1.DataSource = dataSet.Tables["patientsInfo"];
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

