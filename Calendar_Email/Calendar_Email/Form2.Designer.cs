namespace Calendar_Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_EmailFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userInfoEnter = new System.Windows.Forms.Button();
            this.userInfoCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_EmailSend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_EmailTo_Show = new System.Windows.Forms.TextBox();
            this.tb_EmailFrom_Show = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bOpenAttachmentDialog = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 30);
            this.label5.TabIndex = 21;
            this.label5.Text = "Calender based Gmail platform";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_EmailFrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.userInfoEnter);
            this.groupBox2.Controls.Add(this.userInfoCancel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 105);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email Sender";
            // 
            // cmb_EmailFrom
            // 
            this.cmb_EmailFrom.FormattingEnabled = true;
            this.cmb_EmailFrom.Location = new System.Drawing.Point(104, 25);
            this.cmb_EmailFrom.Name = "cmb_EmailFrom";
            this.cmb_EmailFrom.Size = new System.Drawing.Size(172, 24);
            this.cmb_EmailFrom.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email From";
            // 
            // userInfoEnter
            // 
            this.userInfoEnter.Location = new System.Drawing.Point(282, 25);
            this.userInfoEnter.Name = "userInfoEnter";
            this.userInfoEnter.Size = new System.Drawing.Size(77, 24);
            this.userInfoEnter.TabIndex = 11;
            this.userInfoEnter.Text = "Enter";
            this.userInfoEnter.UseVisualStyleBackColor = true;
            this.userInfoEnter.Click += new System.EventHandler(this.userInfoEnter_Click);
            // 
            // userInfoCancel
            // 
            this.userInfoCancel.Location = new System.Drawing.Point(282, 61);
            this.userInfoCancel.Name = "userInfoCancel";
            this.userInfoCancel.Size = new System.Drawing.Size(79, 24);
            this.userInfoCancel.TabIndex = 12;
            this.userInfoCancel.Text = "Clear";
            this.userInfoCancel.UseVisualStyleBackColor = true;
            this.userInfoCancel.Click += new System.EventHandler(this.userInfoCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(104, 63);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(172, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_EmailSend);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_EmailTo_Show);
            this.groupBox3.Controls.Add(this.tb_EmailFrom_Show);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.bOpenAttachmentDialog);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 371);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email Action";
            // 
            // btn_EmailSend
            // 
            this.btn_EmailSend.Location = new System.Drawing.Point(144, 317);
            this.btn_EmailSend.Name = "btn_EmailSend";
            this.btn_EmailSend.Size = new System.Drawing.Size(89, 27);
            this.btn_EmailSend.TabIndex = 9;
            this.btn_EmailSend.Text = "Send Email";
            this.btn_EmailSend.UseVisualStyleBackColor = true;
            this.btn_EmailSend.Click += new System.EventHandler(this.btn_EmailSend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email From:";
            // 
            // tb_EmailTo_Show
            // 
            this.tb_EmailTo_Show.Location = new System.Drawing.Point(91, 50);
            this.tb_EmailTo_Show.Name = "tb_EmailTo_Show";
            this.tb_EmailTo_Show.Size = new System.Drawing.Size(251, 22);
            this.tb_EmailTo_Show.TabIndex = 7;
            // 
            // tb_EmailFrom_Show
            // 
            this.tb_EmailFrom_Show.Location = new System.Drawing.Point(91, 20);
            this.tb_EmailFrom_Show.Name = "tb_EmailFrom_Show";
            this.tb_EmailFrom_Show.Size = new System.Drawing.Size(251, 22);
            this.tb_EmailFrom_Show.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please type the content of this email here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please type the title of the email:";
            // 
            // bOpenAttachmentDialog
            // 
            this.bOpenAttachmentDialog.Location = new System.Drawing.Point(23, 289);
            this.bOpenAttachmentDialog.Name = "bOpenAttachmentDialog";
            this.bOpenAttachmentDialog.Size = new System.Drawing.Size(89, 27);
            this.bOpenAttachmentDialog.TabIndex = 5;
            this.bOpenAttachmentDialog.Text = "Attachment";
            this.bOpenAttachmentDialog.UseVisualStyleBackColor = true;
            this.bOpenAttachmentDialog.Click += new System.EventHandler(this.bOpenAttachmentDialog_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 155);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 128);
            this.textBox2.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(408, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Email Operations";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button userInfoEnter;
        private System.Windows.Forms.Button userInfoCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bOpenAttachmentDialog;
       // private System.Windows.Forms.Button btn_SendEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmb_EmailFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_EmailTo_Show;
        private System.Windows.Forms.TextBox tb_EmailFrom_Show;
        private System.Windows.Forms.Button btn_EmailSend;

    }
}