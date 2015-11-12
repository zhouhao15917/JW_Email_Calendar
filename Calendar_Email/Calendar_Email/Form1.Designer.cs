namespace Calendar_Email
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calendarEmailDataSet = new Calendar_Email.CalendarEmailDataSet();
            this.calendarEmailDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_lable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connTest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addItems = new System.Windows.Forms.LinkLabel();
            this.addNewAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calendarEmailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarEmailDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarEmailDataSet
            // 
            this.calendarEmailDataSet.DataSetName = "CalendarEmailDataSet";
            this.calendarEmailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calendarEmailDataSetBindingSource
            // 
            this.calendarEmailDataSetBindingSource.DataSource = this.calendarEmailDataSet;
            this.calendarEmailDataSetBindingSource.Position = 0;
            // 
            // test_lable
            // 
            this.test_lable.AutoSize = true;
            this.test_lable.Location = new System.Drawing.Point(457, 11);
            this.test_lable.Name = "test_lable";
            this.test_lable.Size = new System.Drawing.Size(0, 17);
            this.test_lable.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "UserName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(85, 38);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(100, 22);
            this.textBox_userName.TabIndex = 16;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(85, 65);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(100, 22);
            this.textBox_Password.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.textBox_userName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(166, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 128);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // btn_login
            // 
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.Location = new System.Drawing.Point(7, 93);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(77, 35);
            this.btn_login.TabIndex = 16;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 133);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // connTest
            // 
            this.connTest.AutoSize = true;
            this.connTest.Location = new System.Drawing.Point(163, -6);
            this.connTest.Name = "connTest";
            this.connTest.Size = new System.Drawing.Size(0, 17);
            this.connTest.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear Forms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addItems
            // 
            this.addItems.AutoSize = true;
            this.addItems.Location = new System.Drawing.Point(312, 147);
            this.addItems.Name = "addItems";
            this.addItems.Size = new System.Drawing.Size(37, 17);
            this.addItems.TabIndex = 23;
            this.addItems.TabStop = true;
            this.addItems.Text = "here";
            this.addItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addItems_LinkClicked);
            // 
            // addNewAccount
            // 
            this.addNewAccount.AutoSize = true;
            this.addNewAccount.Location = new System.Drawing.Point(34, 147);
            this.addNewAccount.Name = "addNewAccount";
            this.addNewAccount.Size = new System.Drawing.Size(323, 17);
            this.addNewAccount.TabIndex = 24;
            this.addNewAccount.Text = "If you want to add new account, please click         .";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(381, 168);
            this.Controls.Add(this.addItems);
            this.Controls.Add(this.connTest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.test_lable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addNewAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarEmailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarEmailDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource calendarEmailDataSetBindingSource;
        private CalendarEmailDataSet calendarEmailDataSet;
        private System.Windows.Forms.Label test_lable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label connTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel addItems;
        private System.Windows.Forms.Label addNewAccount;
    }
}

