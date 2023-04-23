using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_pwd_con_TextChanged(object sender, EventArgs e)
        {

        }
        public static int ExecuteSql(string SQLString)
        {
            string _connString = "Data Source=DESKTOP-UBBFG4S\\SQLEXPRESS01;Initial Catalog=HIS;Integrated Security=True";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-UBBFG4S\\SQLEXPRESS01;Initial Catalog=HIS;Integrated Security=True";
            try
            {
                // Establish connection to SQL Server database
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Check if IDCard already exists in patiinfo table
                    string selectSql = "select * from patientsinfo where IDCard='" + IDCard + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectSql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        MessageBox.Show("您已经注册过，请登录");

                    // If IDCard does not exist, find the max CardNo and insert a new row in patiinfo table
                    string selectSql2 = "select max(CardNo) from patientsinfo";
                    SqlDataAdapter adapter2 = new SqlDataAdapter(selectSql2, connection);
                    DataSet ds2 = new DataSet();
                    adapter2.Fill(ds2);
                    int currentCard = 1;
                    if (ds2.Tables.Count > 0 && ds2.Tables[0].Rows.Count > 0)
                    {
                        int maxCardNo;
                        if (int.TryParse(ds2.Tables[0].Rows[0][0].ToString(), out maxCardNo))
                        {
                            currentCard = maxCardNo + 1;
                        }
                        else
                        {
                            // Handle the case where the maxCardNo is not a valid integer
                        }
                    }

                    string insertSql = "insert into patientsinfo(PatiName,PassWord,Address,Phone,IDCard,CardNo) values(";
                    insertSql += "'" + PatiName.Text + "','" + tb_pwd.Text + "','" + tb_Address.Text + "','" + tb_Phone.Text + "','" + IDCard.Text + "','00000" + currentCard + "')";
                    SqlCommand command = new SqlCommand(insertSql, connection);
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                        MessageBox.Show("注册成功，您的就诊卡号是" + "00000" + currentCard);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }







        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_pwd.PasswordChar = '\0';
        }

        private void td_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_pwd.Text = "";
            tb_pwd_con.Text = "";
            PatiName.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 挂号ToolStripMenuItem_Click(object sender, EventArgs e)
        {// 创建新窗体对象
            Form2 form2 = new Form2();

            // 显示新窗体
            form2.Show();

            // 隐藏当前窗体
            this.Hide();
        }
    }
}