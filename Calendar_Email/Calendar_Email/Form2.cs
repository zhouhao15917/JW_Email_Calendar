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
    public partial class Form2 : Form
    {
        //String[] attachementNames;
        String attachementNames = "";
        String iUserID = "";
        String iPassWord = "";
        String iMailFrom = "zhouhao15917@gmail.com"; //default
        String iMailTo = "zhouhao15917@gmail.com"; //default

        private OleDbConnection connection = new OleDbConnection();

        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CalendarEmail.accdb;
Persist Security Info=False;";  //@ take whole thing as a string.
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                // use this command for the connection which was just built.
                command.Connection = connection;

                String cmd = "select * from emailAddress";

                //command used to excute the database
                command.CommandText = cmd;
                //excuted the database, since nothing will be read here
                OleDbDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    cmb_EmailFrom.Items.Add(reader["Email"].ToString());
                }
                // read data from OLEDB
                //OleDbDataReader reader = command.ExecuteReader();
                MessageBox.Show("");
                //clear all textBoxes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();
            }
            tb_EmailFrom_Show.ReadOnly = true;
        }

        private void userInfoEnter_Click(object sender, EventArgs e)
        {
            if ((cmb_EmailFrom.Text != "") && (textBoxPassword.Text != ""))
            {
                //account ID
                iUserID = cmb_EmailFrom.Text;
                //associated password
                iPassWord = textBoxPassword.Text;
                //email sender is the same as user 
                // TODO: emailfrom can be different from user ID.
                iMailFrom = iUserID;
                //clear the comb box and textbox.
                cmb_EmailFrom.Text = "";
                textBoxPassword.Clear();
                //to change the value of tb tb_EmailFrom_Show, we need to set readonly property as false.
                tb_EmailFrom_Show.ReadOnly = false;
                tb_EmailFrom_Show.Text = iUserID;
                tb_EmailFrom_Show.ReadOnly = true;
                tb_EmailTo_Show.Text = iMailTo;

            }
            else
                MessageBox.Show("Before clicking\"Enter\", please enter ID and password!!");
        }

        private void btn_EmailSend_Click(object sender, EventArgs e)
        {
            String emailSubject = textBox1.Text;
            String emailBody = textBox2.Text;
            String userPassword = textBoxPassword.Text;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(iMailFrom);
                mail.To.Add(iMailTo);
                mail.Subject = emailSubject;
                mail.Body = emailBody;

                if (attachementNames != "")
                {
                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(attachementNames);
                    mail.Attachments.Add(attachment);
                }
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(iUserID, iPassWord);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Email Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bOpenAttachmentDialog_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files(*.*)|*.*";
            //show first option as default
            openFileDialog1.FilterIndex = 1;

            //allow to select more than one file.
            openFileDialog1.Multiselect = true;
            //call the ShowDialog method to show the dialog box
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                attachementNames = openFileDialog1.FileName;
            }
            else if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                MessageBox.Show("Unfortunately, you have to select a file, \n if you want to attach file to your email");
        }

        private void userInfoCancel_Click(object sender, EventArgs e)
        {
            cmb_EmailFrom.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
