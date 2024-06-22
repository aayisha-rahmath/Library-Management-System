using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class FormMain : Form
    {
        public string UserType { get; set; }
        public FormMain(string userType)
        {
            InitializeComponent();
            UserType = userType;
            SetPrivileges();
        }

        MySqlConnection conn = new MySqlConnection(db.connectionString);

        private void SetPrivileges()
        {
            if(UserType == "Admin")
            {
                button8.Visible = true;
            }    
            else
            {
                button8.Visible = false;
            }
        }

        private void TotalMembers()
        {
            try
            {
                conn.Open();
                string query = "SELECT count(*) FROM librarydb.tblmember;";
                MySqlCommand command = new MySqlCommand(query, conn);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
                foreach (DataRow dr in table.Rows)
                {
                    lblmember.Text = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void TotalBooks()
        {
            try
            {
                conn.Open();
                string query = "SELECT count(*) FROM librarydb.tblbooks;";
                MySqlCommand command = new MySqlCommand(query, conn);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
                foreach (DataRow dr in table.Rows)
                {
                    lblbooks.Text = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void TotalStaff()
        {
            try
            {
                conn.Open();
                string query = "SELECT count(*) FROM librarydb.tblstaff;";
                MySqlCommand command = new MySqlCommand(query, conn);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
                foreach (DataRow dr in table.Rows)
                {
                    lblstaff.Text = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void TotalIssues()
        {
            try
            {
                conn.Open();
                string query = "SELECT count(*) FROM librarydb.tblissue;";
                MySqlCommand command = new MySqlCommand(query, conn);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
                foreach (DataRow dr in table.Rows)
                {
                    lblIssue.Text = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void TotalReturns()
        {
            try
            {
                conn.Open();
                string query = "SELECT count(*) FROM librarydb.tblreturn;";
                MySqlCommand command = new MySqlCommand(query, conn);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
                foreach (DataRow dr in table.Rows)
                {
                    lblreturn.Text = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook(UserType);
            formBook.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStaff formStaff = new FormStaff(UserType);
            formStaff.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormIssue formIssue = new FormIssue(UserType);
            formIssue.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReturn formReturn = new FormReturn(UserType);
            formReturn.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormMember formMember = new FormMember(UserType);   
            formMember.Show(); 
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            TotalMembers();
            TotalBooks();
            TotalStaff();
            TotalIssues();
            TotalReturns();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers(UserType);
            formUsers.ShowDialog();
            this.Hide();
        }
    }
}
