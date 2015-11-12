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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CalendarEmail.accdb;
Persist Security Info=False;";  //@ take whole thing as a string.
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connTest.Text = "Database Connection Sucessfully";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        
        //process when click "X" button to close the Form
        void Form1_FormClosed(Object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (this.DialogResult == DialogResult.Cancel)
            {
                switch (MessageBox.Show(this, "Are you sure?", "Do you want to..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        Application.Exit();
                        break;
                    default:
                        break;
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                // use this command for the connection we just built.
                command.Connection = connection;
                command.CommandText = "select * from userInfo where Username='" + textBox_userName.Text + "' and Password='" + textBox_Password.Text + "'";
                // read data from OLEDB
                OleDbDataReader reader =  command.ExecuteReader();
                int count = 0;
                //ret: bool
                while(reader.Read())
                {
                    count++;

                }
                if(count == 1)
                {
                    //MessageBox.Show("Username and Password are correct");
                    connection.Close();
                    connection.Dispose();
                    //hide the current form
                    this.Hide();
                    Form2 f2 = new Form2();
                    //show form2
                    f2.ShowDialog();

                }
                // if read the same item more than one time, it will be duplicated.
                else if(count > 1)
                {
                    MessageBox.Show("Username and Password are Duplicate");
                }
                else
                {
                    MessageBox.Show("Username and Password are not correct");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_userName.Clear();
            textBox_Password.Clear();
        }

        private void addItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //hide the current form
            this.Hide();
            Form3 f3 = new Form3();
            //show Form3
            f3.ShowDialog();
        }

    }
}
