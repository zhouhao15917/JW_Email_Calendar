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
        
        //Create the connection with database
        private OleDbConnection connection = new OleDbConnection();
        
        //Start building up email system
        private MailMessage mail = new MailMessage();
        //set up email server. For now it's for gmail(smtp). TODO: provide several options.
        private SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");


        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CalendarEmail.accdb;
Persist Security Info=False;";  //@ take whole thing as a string.
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
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
                MessageBox.Show("Data loaded from database to combBox correctly!!");
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
            //Initiate email client
            //email_Init();
            //Initiate email stmp server
            //stmp_Init();
            //initiate Email From textbox.
            tb_EmailFrom_Show.ReadOnly = true;
        }
        void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (this.DialogResult == DialogResult.Cancel)
            {
                switch (MessageBox.Show(this, "Are you sure?", "Do you want to ...?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        Application.Exit();
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void userInfoEnter_Click(object sender, EventArgs e)
        {
            //account ID
            iUserID = cmb_EmailFrom.Text;
            //associated password
            iPassWord = textBoxPassword.Text;

            try
            {
//                SmtpServer.Send(mail);                //email sender is the same as user 
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
            catch 
            {
                MessageBox.Show("You account ID doesn't match the password!");
                //clear the comb box and textbox.
                cmb_EmailFrom.Text = "";
                textBoxPassword.Clear();
            }
        }

        //clear user ID/password
        private void userInfoCancel_Click(object sender, EventArgs e)
        {
            cmb_EmailFrom.Text = "";
            textBoxPassword.Text = "";
        }

       
        //process the attachement along with the email
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
                atchName.Text = attachementNames.Substring(attachementNames.LastIndexOf('\\') + 1);
            }
            else if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                MessageBox.Show("Unfortunately, you have to select a file, \n if you want to attach a file to your email");
        }
        
        //initiate email
        private void email_Init()
        {
            String emailSubject = textBox1.Text;
            String emailBody = textBox2.Text;
            mail.From = new MailAddress(iMailFrom);
            mail.To.Add(iMailTo);
            mail.Subject = emailSubject;
            mail.Body = emailBody;
        }

        private void stmp_Init()
        {
//          String userPassword = textBoxPassword.Text;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(iUserID, iPassWord);
            SmtpServer.EnableSsl = true;
        }

        private void btn_EmailSend_Click(object sender, EventArgs e)
        {
            try
            {
                stmp_Init();
                email_Init();
                if (attachementNames != "")
                {
                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(attachementNames);
                    mail.Attachments.Add(attachment);
                }
                SmtpServer.Send(mail);
                MessageBox.Show("Congrats! Email Sent Sucessfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_SetUpAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            //show form2
            f4.ShowDialog();
        }
    }
}
