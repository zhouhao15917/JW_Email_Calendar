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
            this.label3 = new System.Windows.Forms.Label();
            this.userInfoEnter = new System.Windows.Forms.Button();
            this.userInfoCancel = new System.Windows.Forms.Button();
            this.textBoxIUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bOpenAttachmentDialog = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.emailFrom = new System.Windows.Forms.ComboBox();
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
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.userInfoEnter);
            this.groupBox2.Controls.Add(this.userInfoCancel);
            this.groupBox2.Controls.Add(this.textBoxIUserID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 105);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "User ID";
            // 
            // userInfoEnter
            // 
            this.userInfoEnter.Location = new System.Drawing.Point(74, 64);
            this.userInfoEnter.Name = "userInfoEnter";
            this.userInfoEnter.Size = new System.Drawing.Size(104, 24);
            this.userInfoEnter.TabIndex = 11;
            this.userInfoEnter.Text = "Enter";
            this.userInfoEnter.UseVisualStyleBackColor = true;
            // 
            // userInfoCancel
            // 
            this.userInfoCancel.Location = new System.Drawing.Point(200, 61);
            this.userInfoCancel.Name = "userInfoCancel";
            this.userInfoCancel.Size = new System.Drawing.Size(106, 24);
            this.userInfoCancel.TabIndex = 12;
            this.userInfoCancel.Text = "Clear";
            this.userInfoCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxIUserID
            // 
            this.textBoxIUserID.Location = new System.Drawing.Point(74, 32);
            this.textBoxIUserID.Name = "textBoxIUserID";
            this.textBoxIUserID.Size = new System.Drawing.Size(106, 22);
            this.textBoxIUserID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(200, 33);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(106, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.bOpenAttachmentDialog);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 330);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email Action";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please type the content of this email here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please type the title of the email:";
            // 
            // bOpenAttachmentDialog
            // 
            this.bOpenAttachmentDialog.Location = new System.Drawing.Point(23, 242);
            this.bOpenAttachmentDialog.Name = "bOpenAttachmentDialog";
            this.bOpenAttachmentDialog.Size = new System.Drawing.Size(89, 27);
            this.bOpenAttachmentDialog.TabIndex = 5;
            this.bOpenAttachmentDialog.Text = "Attachment";
            this.bOpenAttachmentDialog.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Send Email";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 108);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 128);
            this.textBox2.TabIndex = 2;
            // 
            // emailFrom
            // 
            this.emailFrom.FormattingEnabled = true;
            this.emailFrom.Location = new System.Drawing.Point(12, 176);
            this.emailFrom.Name = "emailFrom";
            this.emailFrom.Size = new System.Drawing.Size(121, 24);
            this.emailFrom.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 599);
            this.Controls.Add(this.emailFrom);
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
        private System.Windows.Forms.TextBox textBoxIUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bOpenAttachmentDialog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox emailFrom;

    }
}