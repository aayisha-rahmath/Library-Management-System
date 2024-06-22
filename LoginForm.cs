using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            /*
            MySqlConnection conn = new MySqlConnection("server=localhost; user=root; database=librarydb; password=");
            MySqlCommand cmd;
            MySqlDataReader mdr;

            try
            {
                conn.Open();
                MessageBox.Show("Connection success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {

            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtpassword.Text) || cbusertype.SelectedItem == null)
            {
                MessageBox.Show("Please enter username, password, and user type");
                return;
            }
            else
            {
                string query = "SELECT * FROM users WHERE username = @username AND password = @password AND userType = @userType";
                MySqlConnection conn = new MySqlConnection(db.connectionString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;

                try
                {
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@userType", cbusertype.SelectedItem);

                    conn.Open();
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show("Login success!");
                            string userType = reader["userType"].ToString();
                            FormIssue frmIssue = new FormIssue(userType);
                            FormBook formBook = new FormBook(userType);
                            FormReturn frmReturn = new FormReturn(userType);
                            FormMember formMember = new FormMember(userType);
                            FormUsers formUsers = new FormUsers(userType);


                            FormMain formMain = new FormMain(userType);
                            formMain.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
