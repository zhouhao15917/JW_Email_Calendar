using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.OleDb; //MS access database

namespace Calendar_Email
{
    public partial class Form4 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
       
        //Local variables
        private String emailFrom = "";
        private String emailTo = "";


        //Start building up email system
       private MailMessage mail = new MailMessage();
        //set up email server. For now it's for gmail(smtp). TODO: provide several options.
       private SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

        public Form4()
        {
            InitializeComponent();
            lb_Note1.MaximumSize = new Size(500, 0);
            lb_Note1.AutoSize = true;
            //setup access database directory
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CalendarEmail.accdb;
Persist Security Info=False;";  //@ take whole thing as a string.
            //take care of "X" click button.
            this.FormClosing += new FormClosingEventHandler(Form4_FormClosing);
        }

        //process when click "X" button to close the Form
        void Form4_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Form2 f2 = new Form2();
            // When the operating system is closing all applications before shutting down, do nothing.
            if (e.CloseReason == CloseReason.WindowsShutDown) Application.Exit();
            else if (e.CloseReason == CloseReason.UserClosing)
            {
                if (this.DialogResult == DialogResult.Cancel)
                {
                    switch (MessageBox.Show(this, "Are you sure?", "Do you want to..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            //this "close" event would be excuted.
                            this.Hide();
                            e.Cancel = false;
                            f2.ShowDialog();
                            break;
                        case DialogResult.No:
                            //this close event would be canclled.
                            e.Cancel = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                //do nothing
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                dBConn_Test.Text = "Database Connection Sucessfully";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        //initiate email
        private void email_Init(String iMailFrom, String iMailTo)
        {
            String emailSubject = "test";
            String emailBody = "Congrats! The account is corrct!\n Hao Zhou";
            mail.From = new MailAddress(iMailFrom);
            mail.To.Add(iMailTo);
            mail.Subject = emailSubject;
            mail.Body = emailBody;
        }

        private void stmp_Init(String iUserID, String iPassWord)
        {
            //          String userPassword = textBoxPassword.Text;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(iUserID, iPassWord);
            SmtpServer.EnableSsl = true;
        }

        private void btn_TestAccount_Click(object sender, EventArgs e)
        {
            String newEmailAddr = tb_EmailAddress.Text;
            String newPassword = tb_Password.Text;
            //set up stmp
            stmp_Init(newEmailAddr, newPassword);
            //send test email
            email_Init(newEmailAddr, newPassword);
            try
            {
                SmtpServer.Send(mail);
                //save info into DB.
            }
            catch
            {
                MessageBox.Show("The account is not coorect.");
            }
        }
    }
}
