using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Calendar_Email
{

    public partial class Form3 : Form
    {
        //creat an access database connection.
        private OleDbConnection connection = new OleDbConnection();
        
        // this method is used to clear all textboxes.
        private void clearAllTextBoxes()
        {
            tb_firstName.Clear();
            tb_lastName.Clear();
            tb_userID.Clear();
            tb_passWord.Clear();
        }
        public Form3()
        {
            InitializeComponent();
            //connect the database
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hzhou\Documents\Visual Studio 2013\Projects\Calendar_Email\Calendar_Email\CalendarEmail.accdb;
Persist Security Info=False;";  //@ take whole thing as a string.
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            //define Form1
            Form1 f1 = new Form1();
            //back to Form1
            f1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                // use this command for the connection which was just built.
                command.Connection = connection;
                String firstName = tb_firstName.Text.ToString();
                String lastName = tb_lastName.Text.ToString();
                String userName = tb_userID.Text.ToString();
                String passWord = tb_passWord.Text.ToString();
            
                //command used to excute the database
//                command.CommandText = "INSERT into userInfo (FirstName,LastName,UserName,Password)" +
//                    "VALUES('" + firstName + "','" + lastName + "','" + userName + "','" + passWord + "')";
                command.CommandText = "INSERT into userInfo (FirstName,LastName,UserName,Password)" +
                    "VALUES('" + firstName + "','" + lastName + "','" + userName + "','" + passWord + "')";
                //excuted the database, since nothing will be read here
                command.ExecuteNonQuery();
                // read data from OLEDB
                //OleDbDataReader reader = command.ExecuteReader();
                MessageBox.Show("New Account Saved,\nYou can add another new account!");
                //clear all textBoxes
                clearAllTextBoxes();
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

        private void btn_clearForm_Click(object sender, EventArgs e)
        {
            //clear all textBoxes
            clearAllTextBoxes();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                btn_clearForm.Text = "Congrats!\nDatabase Connection Sucessfully!!";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                // use this command for the connection which was just built.
                command.Connection = connection;
                String firstName = tb_firstName.Text.ToString();
                String lastName = tb_lastName.Text.ToString();
                String userName = tb_userID.Text.ToString();
                String passWord = tb_passWord.Text.ToString();
                String ID_edit = tb_ID.Text;

                String cmd = "update userInfo set FirstName = '" + firstName + "', LastName = '" + lastName + "', UserName = '" + userName + "', Password = '" + passWord + "' where ID=" + ID_edit + "";
                MessageBox.Show(cmd);

                //command used to excute the database
                command.CommandText = cmd;
                //excuted the database, since nothing will be read here
                command.ExecuteNonQuery();
                // read data from OLEDB
                //OleDbDataReader reader = command.ExecuteReader();
                MessageBox.Show("Account " + ID_edit + " Is Updated!");
                //clear all textBoxes
                clearAllTextBoxes();
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
    }
}
