namespace Calendar_Email
{
    partial class Form4
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
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_EmailAddress = new System.Windows.Forms.TextBox();
            this.lb_EmailAddress = new System.Windows.Forms.Label();
            this.btn_TestAccount = new System.Windows.Forms.Button();
            this.lb_Note1 = new System.Windows.Forms.Label();
            this.dBConn_Test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(224, 132);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(235, 38);
            this.tb_Password.TabIndex = 16;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(26, 139);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(139, 32);
            this.lb_Password.TabIndex = 15;
            this.lb_Password.Text = "Password";
            // 
            // tb_EmailAddress
            // 
            this.tb_EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EmailAddress.Location = new System.Drawing.Point(224, 80);
            this.tb_EmailAddress.Name = "tb_EmailAddress";
            this.tb_EmailAddress.Size = new System.Drawing.Size(235, 38);
            this.tb_EmailAddress.TabIndex = 14;
            // 
            // lb_EmailAddress
            // 
            this.lb_EmailAddress.AutoSize = true;
            this.lb_EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmailAddress.Location = new System.Drawing.Point(26, 86);
            this.lb_EmailAddress.Name = "lb_EmailAddress";
            this.lb_EmailAddress.Size = new System.Drawing.Size(198, 32);
            this.lb_EmailAddress.TabIndex = 13;
            this.lb_EmailAddress.Text = "Email Address";
            // 
            // btn_TestAccount
            // 
            this.btn_TestAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestAccount.Location = new System.Drawing.Point(154, 214);
            this.btn_TestAccount.Name = "btn_TestAccount";
            this.btn_TestAccount.Size = new System.Drawing.Size(210, 42);
            this.btn_TestAccount.TabIndex = 17;
            this.btn_TestAccount.Text = "Test Account";
            this.btn_TestAccount.UseVisualStyleBackColor = true;
            this.btn_TestAccount.Click += new System.EventHandler(this.btn_TestAccount_Click);
            // 
            // lb_Note1
            // 
            this.lb_Note1.AutoSize = true;
            this.lb_Note1.ForeColor = System.Drawing.Color.Red;
            this.lb_Note1.Location = new System.Drawing.Point(26, 305);
            this.lb_Note1.Name = "lb_Note1";
            this.lb_Note1.Size = new System.Drawing.Size(471, 17);
            this.lb_Note1.TabIndex = 18;
            this.lb_Note1.Text = "Note: Once email account can be validated, it would be save to database.";
            // 
            // dBConn_Test
            // 
            this.dBConn_Test.AutoSize = true;
            this.dBConn_Test.Location = new System.Drawing.Point(161, 29);
            this.dBConn_Test.Name = "dBConn_Test";
            this.dBConn_Test.Size = new System.Drawing.Size(0, 17);
            this.dBConn_Test.TabIndex = 19;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 448);
            this.Controls.Add(this.dBConn_Test);
            this.Controls.Add(this.lb_Note1);
            this.Controls.Add(this.btn_TestAccount);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.tb_EmailAddress);
            this.Controls.Add(this.lb_EmailAddress);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_EmailAddress;
        private System.Windows.Forms.Label lb_EmailAddress;
        private System.Windows.Forms.Button btn_TestAccount;
        private System.Windows.Forms.Label lb_Note1;
        private System.Windows.Forms.Label dBConn_Test;
    }
}