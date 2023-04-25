namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label6 = new Label();
            lblPatiName = new Label();
            btnSearch_Click = new Button();
            txtCardNo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            empid = new ComboBox();
            orgtypeid = new ComboBox();
            regdate = new DateTimePicker();
            orgid = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblPatiName);
            groupBox1.Controls.Add(btnSearch_Click);
            groupBox1.Controls.Add(txtCardNo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(46, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(701, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "患者信息";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 63);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 4;
            label6.Text = "患者姓名：";
            // 
            // lblPatiName
            // 
            lblPatiName.AutoSize = true;
            lblPatiName.Location = new Point(109, 63);
            lblPatiName.Name = "lblPatiName";
            lblPatiName.Size = new Size(0, 17);
            lblPatiName.TabIndex = 3;
            // 
            // btnSearch_Click
            // 
            btnSearch_Click.Location = new Point(319, 30);
            btnSearch_Click.Name = "btnSearch_Click";
            btnSearch_Click.Size = new Size(75, 23);
            btnSearch_Click.TabIndex = 2;
            btnSearch_Click.Text = "查询";
            btnSearch_Click.UseVisualStyleBackColor = true;
            btnSearch_Click.Click += button1_Click;
            // 
            // txtCardNo
            // 
            txtCardNo.Location = new Point(168, 30);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.Size = new Size(100, 23);
            txtCardNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 30);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 0;
            label1.Text = "请输入就诊卡号：";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(empid);
            groupBox2.Controls.Add(orgtypeid);
            groupBox2.Controls.Add(regdate);
            groupBox2.Controls.Add(orgid);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(43, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(706, 272);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "挂号界面";
            // 
            // button2
            // 
            button2.Location = new Point(297, 202);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "挂号";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // empid
            // 
            empid.FormattingEnabled = true;
            empid.Items.AddRange(new object[] { "医生" });
            empid.Location = new Point(450, 104);
            empid.Name = "empid";
            empid.Size = new Size(121, 25);
            empid.TabIndex = 7;
            // 
            // orgtypeid
            // 
            orgtypeid.FormattingEnabled = true;
            orgtypeid.Items.AddRange(new object[] { "门诊号", "急诊号" });
            orgtypeid.Location = new Point(180, 104);
            orgtypeid.Name = "orgtypeid";
            orgtypeid.Size = new Size(121, 25);
            orgtypeid.TabIndex = 6;
            // 
            // regdate
            // 
            regdate.Format = DateTimePickerFormat.Short;
            regdate.Location = new Point(180, 46);
            regdate.Name = "regdate";
            regdate.Size = new Size(121, 23);
            regdate.TabIndex = 5;
            regdate.Value = new DateTime(2023, 4, 23, 20, 10, 41, 0);
            regdate.ValueChanged += regdate_ValueChanged;
            // 
            // orgid
            // 
            orgid.FormattingEnabled = true;
            orgid.Items.AddRange(new object[] { "内科", "外科" });
            orgid.Location = new Point(450, 44);
            orgid.Name = "orgid";
            orgid.Size = new Size(121, 25);
            orgid.TabIndex = 4;
            orgid.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 107);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 3;
            label5.Text = "请选择医生：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 50);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 2;
            label4.Text = "请选择科室：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 107);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 1;
            label3.Text = "请选择挂号类型：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 47);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 0;
            label2.Text = "请选择挂号时间：";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "挂号";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnSearch_Click;
        private TextBox txtCardNo;
        private GroupBox groupBox2;
        private ComboBox orgid;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private ComboBox empid;
        private ComboBox orgtypeid;
        private DateTimePicker regdate;
        private Label lblPatiName;
        private Label label6;
    }
}