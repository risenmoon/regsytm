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
            tb_user = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_pwd = new TextBox();
            tb_pwd_con = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            用户管理ToolStripMenuItem = new ToolStripMenuItem();
            挂号管理ToolStripMenuItem = new ToolStripMenuItem();
            注册界面 = new GroupBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.BackColor = SystemColors.Control;
            lbl_user.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_user.Location = new Point(120, 136);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(159, 28);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "请输入用户名：";
            lbl_user.Click += label1_Click;
            // 
            // tb_user
            // 
            tb_user.BackColor = SystemColors.Window;
            tb_user.ForeColor = SystemColors.ActiveCaptionText;
            tb_user.Location = new Point(303, 134);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(150, 30);
            tb_user.TabIndex = 1;
            tb_user.TextChanged += tb_pwd_con_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 234);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 2;
            label1.Text = "请输入密码：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(120, 322);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 3;
            label2.Text = "请输入密码：";
            // 
            // tb_pwd
            // 
            tb_pwd.BackColor = SystemColors.Window;
            tb_pwd.ForeColor = SystemColors.ActiveCaptionText;
            tb_pwd.Location = new Point(303, 234);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.PasswordChar = '*';
            tb_pwd.Size = new Size(150, 30);
            tb_pwd.TabIndex = 4;
            tb_pwd.TextChanged += td_pwd_TextChanged;
            // 
            // tb_pwd_con
            // 
            tb_pwd_con.BackColor = SystemColors.Window;
            tb_pwd_con.ForeColor = SystemColors.ActiveCaptionText;
            tb_pwd_con.Location = new Point(303, 322);
            tb_pwd_con.Name = "tb_pwd_con";
            tb_pwd_con.PasswordChar = '*';
            tb_pwd_con.Size = new Size(150, 30);
            tb_pwd_con.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(136, 425);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "注册";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(389, 425);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(513, 239);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 9;
            button4.Text = "显示密码";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 用户管理ToolStripMenuItem, 挂号管理ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            用户管理ToolStripMenuItem.Size = new Size(98, 28);
            用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 挂号管理ToolStripMenuItem
            // 
            挂号管理ToolStripMenuItem.Name = "挂号管理ToolStripMenuItem";
            挂号管理ToolStripMenuItem.Size = new Size(98, 28);
            挂号管理ToolStripMenuItem.Text = "挂号管理";
            // 
            // 注册界面
            // 
            注册界面.Location = new Point(39, 79);
            注册界面.Name = "注册界面";
            注册界面.Size = new Size(660, 494);
            注册界面.TabIndex = 11;
            注册界面.TabStop = false;
            注册界面.Text = "注册界面";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 679);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tb_pwd_con);
            Controls.Add(tb_pwd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_user);
            Controls.Add(lbl_user);
            Controls.Add(menuStrip1);
            Controls.Add(注册界面);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_user;
        private TextBox tb_user;
        private Label label1;
        private Label label2;
        private TextBox tb_pwd;
        private TextBox tb_pwd_con;
        private Button button1;
        private Button button2;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 用户管理ToolStripMenuItem;
        private ToolStripMenuItem 挂号管理ToolStripMenuItem;
        private GroupBox 注册界面;
    }
}