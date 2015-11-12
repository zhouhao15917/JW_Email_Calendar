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
        String iMailFrom = "zhouhao15917@gmail.com";
        String iMailTo = "zhouhao15917@gmail.com";

        private OleDbConnection connection = new OleDbConnection();

        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hzhou\Documents\Visual Studio 2013\Projects\Calendar_Email\Calendar_Email\CalendarEmail.accdb;
Persist Security Info=False;";  //@ take whole thing as a string.
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            button2.Enabled = false;
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
                    emailFrom.Items.Add(reader["Email"].ToString());
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
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String emailSubject = textBox1.Text;
            String emailBody = textBox2.Text;
            String userID = textBoxIUserID.Text;
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

        private void userInfoEnter_Click(object sender, EventArgs e)
        {
            if ((textBoxIUserID.Text != "") && (textBoxPassword.Text != ""))
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                button2.Enabled = true;
                textBoxIUserID.ReadOnly = true;
                textBoxPassword.ReadOnly = true;
                userInfoEnter.Enabled = false;
                userInfoCancel.Enabled = false;
                textBoxIUserID.Text = "";
                textBoxPassword.Text = "";
                iUserID = textBoxIUserID.Text;
                iPassWord = textBoxPassword.Text;

            }
            else
                MessageBox.Show("Before clicking\"Enter\", please enter ID and password!!");
        }

        private void userInfoCancel_Click(object sender, EventArgs e)
        {
            textBoxIUserID.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
