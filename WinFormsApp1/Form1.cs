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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source=DESKTOP-UBBFG4S\SQLEXPRESS01;Initial Catalog=HIS;Integrated Security=True";
                //��ѯ���֤�Ƿ����
                selectSql = "select * from patiinfo where IDCard='" + IDCard + "'";
                ds = MySqlHelper.GetDataSet(selectSql);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("���Ѿ�ע��������¼");

                //������֤�Ų����ڣ��Ȳ������ľ��￨�ţ�Ȼ����뻼����Ϣ
                selectSql2 = "select max(CardNo) from patiinfo";
                ds2 = MySqlHelper.GetDataSet(selectSql2);
                if (ds2.Tables.Count > 0 && ds2.Tables[0].Rows.Count > 0)
                    currentCard = Convert.ToInt32(ds2.Tables[0].Rows[0][0].ToString()) + 1;//������������Ϊ1
                insertSql = "insert into patiinfo(PatiName,PassWord,Address,Phone,IDCard,CardNo) values(";
                insertSql += "'{0}','{1}','{2}','{3}','{4}','{5}')";
                insertSql = string.Format(insertSql, PatiName, PassWord, IDCard, Address, Phone, "00000" + currentCard);
                int i = MySqlHelper.ExecuteSql(insertSql);

                if (i > 0)
                    MessageBox.Show("ע��ɹ������ľ��￨����" + "00000" + currentCard);
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
            tb_user.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}