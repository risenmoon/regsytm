namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_user = new Label();
            PatiName = new TextBox();
            label1 = new Label();
            PassWord = new Label();
            tb_pwd = new TextBox();
            tb_pwd_con = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            用户管理ToolStripMenuItem = new ToolStripMenuItem();
            注册界面 = new GroupBox();
            IDCard = new TextBox();
            tb_Address = new TextBox();
            tb_Phone = new TextBox();
            Phone = new Label();
            Address = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            挂号ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            注册界面.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.BackColor = SystemColors.Control;
            lbl_user.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_user.Location = new Point(76, 47);
            lbl_user.Margin = new Padding(2, 0, 2, 0);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(93, 19);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "请输入姓名：";
            lbl_user.Click += label1_Click;
            // 
            // PatiName
            // 
            PatiName.BackColor = SystemColors.Window;
            PatiName.ForeColor = SystemColors.ActiveCaptionText;
            PatiName.Location = new Point(193, 46);
            PatiName.Margin = new Padding(2);
            PatiName.Name = "PatiName";
            PatiName.Size = new Size(97, 23);
            PatiName.TabIndex = 1;
            PatiName.TextChanged += tb_pwd_con_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 96);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 2;
            label1.Text = "请输入密码：";
            // 
            // PassWord
            // 
            PassWord.AutoSize = true;
            PassWord.BackColor = SystemColors.Control;
            PassWord.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            PassWord.Location = new Point(76, 137);
            PassWord.Margin = new Padding(2, 0, 2, 0);
            PassWord.Name = "PassWord";
            PassWord.Size = new Size(93, 19);
            PassWord.TabIndex = 3;
            PassWord.Text = "请输入密码：";
            // 
            // tb_pwd
            // 
            tb_pwd.BackColor = SystemColors.Window;
            tb_pwd.ForeColor = SystemColors.ActiveCaptionText;
            tb_pwd.Location = new Point(193, 96);
            tb_pwd.Margin = new Padding(2);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.PasswordChar = '*';
            tb_pwd.Size = new Size(97, 23);
            tb_pwd.TabIndex = 4;
            tb_pwd.TextChanged += td_pwd_TextChanged;
            // 
            // tb_pwd_con
            // 
            tb_pwd_con.BackColor = SystemColors.Window;
            tb_pwd_con.ForeColor = SystemColors.ActiveCaptionText;
            tb_pwd_con.Location = new Point(193, 137);
            tb_pwd_con.Margin = new Padding(2);
            tb_pwd_con.Name = "tb_pwd_con";
            tb_pwd_con.PasswordChar = '*';
            tb_pwd_con.Size = new Size(97, 23);
            tb_pwd_con.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(88, 312);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(71, 24);
            button1.TabIndex = 6;
            button1.Text = "注册";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(302, 312);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(71, 24);
            button2.TabIndex = 7;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(326, 96);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(71, 24);
            button4.TabIndex = 9;
            button4.Text = "显示密码";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 用户管理ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(509, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // 用户管理ToolStripMenuItem
            // 
            用户管理ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 挂号ToolStripMenuItem });
            用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            用户管理ToolStripMenuItem.Size = new Size(68, 22);
            用户管理ToolStripMenuItem.Text = "用户管理";
            用户管理ToolStripMenuItem.Click += 用户管理ToolStripMenuItem_Click;
            // 
            // 注册界面
            // 
            注册界面.Controls.Add(PatiName);
            注册界面.Controls.Add(IDCard);
            注册界面.Controls.Add(lbl_user);
            注册界面.Controls.Add(tb_Address);
            注册界面.Controls.Add(tb_Phone);
            注册界面.Controls.Add(PassWord);
            注册界面.Controls.Add(button4);
            注册界面.Controls.Add(Phone);
            注册界面.Controls.Add(tb_pwd);
            注册界面.Controls.Add(Address);
            注册界面.Controls.Add(label7);
            注册界面.Controls.Add(label1);
            注册界面.Controls.Add(label4);
            注册界面.Controls.Add(tb_pwd_con);
            注册界面.Controls.Add(label3);
            注册界面.Controls.Add(button1);
            注册界面.Controls.Add(button2);
            注册界面.Location = new Point(29, 35);
            注册界面.Margin = new Padding(2);
            注册界面.Name = "注册界面";
            注册界面.Padding = new Padding(2);
            注册界面.Size = new Size(450, 403);
            注册界面.TabIndex = 11;
            注册界面.TabStop = false;
            注册界面.Text = "注册界面";
            // 
            // IDCard
            // 
            IDCard.BackColor = SystemColors.Window;
            IDCard.ForeColor = SystemColors.ActiveCaptionText;
            IDCard.Location = new Point(193, 181);
            IDCard.Margin = new Padding(2);
            IDCard.Name = "IDCard";
            IDCard.Size = new Size(97, 23);
            IDCard.TabIndex = 12;
            // 
            // tb_Address
            // 
            tb_Address.BackColor = SystemColors.Window;
            tb_Address.ForeColor = SystemColors.ActiveCaptionText;
            tb_Address.Location = new Point(193, 223);
            tb_Address.Margin = new Padding(2);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(97, 23);
            tb_Address.TabIndex = 13;
            // 
            // tb_Phone
            // 
            tb_Phone.BackColor = SystemColors.Window;
            tb_Phone.ForeColor = SystemColors.ActiveCaptionText;
            tb_Phone.Location = new Point(193, 256);
            tb_Phone.Margin = new Padding(2);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.Size = new Size(97, 23);
            tb_Phone.TabIndex = 14;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.BackColor = SystemColors.Control;
            Phone.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            Phone.Location = new Point(80, 256);
            Phone.Margin = new Padding(2, 0, 2, 0);
            Phone.Name = "Phone";
            Phone.Size = new Size(79, 19);
            Phone.TabIndex = 12;
            Phone.Text = "联系电话：";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = SystemColors.Control;
            Address.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            Address.Location = new Point(80, 223);
            Address.Margin = new Padding(2, 0, 2, 0);
            Address.Name = "Address";
            Address.Size = new Size(79, 19);
            Address.TabIndex = 13;
            Address.Text = "家庭住址：";
            Address.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(80, 181);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 19);
            label7.TabIndex = 14;
            label7.Text = "身份证号：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(76, 255);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(76, 218);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 12;
            // 
            // 挂号ToolStripMenuItem
            // 
            挂号ToolStripMenuItem.Name = "挂号ToolStripMenuItem";
            挂号ToolStripMenuItem.Size = new Size(180, 22);
            挂号ToolStripMenuItem.Text = "挂号";
            挂号ToolStripMenuItem.Click += 挂号ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 421);
            Controls.Add(menuStrip1);
            Controls.Add(注册界面);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "注册建卡";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            注册界面.ResumeLayout(false);
            注册界面.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_user;
        private TextBox PatiName;
        private Label label1;
        private Label PassWord;
        private TextBox tb_pwd;
        private TextBox tb_pwd_con;
        private Button button1;
        private Button button2;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 用户管理ToolStripMenuItem;
        private GroupBox 注册界面;
        private Label Address;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label Phone;
        private TextBox IDCard;
        private TextBox tb_Address;
        private TextBox tb_Phone;
        private ToolStripMenuItem 挂号ToolStripMenuItem;
    }
}