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
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class FormUsers : Form
    {
        MySqlConnection conn = new MySqlConnection(db.connectionString);
        public string UserType { get; set; }
        public FormUsers(string userType)
        {
            InitializeComponent();
            UserType = userType;
        }

        private void loadData()
        {
            conn.Open();
            BindingSource bsource = new BindingSource();
            DataTable table = new DataTable();
            string query = "SELECT * FROM librarydb.users";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);
            bsource.DataSource = table;
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Name cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Contact cannot be empty.");
                    return;
                }
                if (cbUserType.SelectedItem == null)
                {
                    MessageBox.Show("Gender must be selected.");
                    return;
                }

                string query = "INSERT INTO `librarydb`.`users` (`username`, `password`, `userType`) VALUES (@username, @password, @userType)";

                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtpassword.Text);
                command.Parameters.AddWithValue("@userType", cbUserType.SelectedItem.ToString());

                command.ExecuteNonQuery();
                conn.Close();
                txtId.Clear();
                txtUsername.Clear();
                txtpassword.Clear();
                loadData();
                MessageBox.Show("Saved User details successfully.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value.ToString();

                if (row.Cells[1].Value != null)
                {
                    txtUsername.Text = row.Cells[1].Value.ToString();
                }
                else
                {
                    txtUsername.Clear(); 
                }

                if (row.Cells[2].Value != null)
                {
                    txtpassword.Text = row.Cells[2].Value.ToString();
                }
                else
                {
                    txtpassword.Clear(); 
                }

                if (row.Cells[3].Value != null)
                {
                    string userType = row.Cells[3].Value.ToString();
                    if (cbUserType.Items.Cast<string>().Any(item => item.Equals(userType, StringComparison.OrdinalIgnoreCase)))
                    {
                        cbUserType.SelectedItem = cbUserType.Items.Cast<string>().First(item => item.Equals(userType, StringComparison.OrdinalIgnoreCase));
                    }
                    else
                    {
                        cbUserType.SelectedIndex = -1; 
                        MessageBox.Show("User type not found in the combo box items.");
                    }
                }
                else
                {
                    cbUserType.SelectedIndex = -1; 
                }

            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Name cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Password cannot be empty.");
                    return;
                }
                if (cbUserType.SelectedItem == null)
                {
                    MessageBox.Show("User type must be selected.");
                    return;
                }

                string updateQuery;
                conn.Open();
                updateQuery = "UPDATE `librarydb`.`users` SET `username` = '" + txtUsername.Text + "', `password` = '" + txtpassword.Text + "', `userType` = '" + cbUserType.SelectedItem.ToString() + "' WHERE `userID` = '" + txtId.Text + "';";
                MySqlCommand command = new MySqlCommand(updateQuery, conn);
                command.ExecuteReader();
                conn.Close();

                txtId.Clear();
                txtUsername.Clear();
                txtpassword.Clear();
                cbUserType.SelectedIndex = -1;

                loadData();

                MessageBox.Show("The user record is updated successfully.");
                txtId.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtUsername.Clear();
            txtpassword.Clear();
            cbUserType.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Please select a user to delete.");
                    return;
                }

                string deleteQuery;
                conn.Open();
                deleteQuery = "DELETE FROM `librarydb`.`users` WHERE `userID` = '" + txtId.Text + "';";
                MySqlCommand command = new MySqlCommand(deleteQuery, conn);
                command.ExecuteReader();
                conn.Close();

                txtId.Clear();
                txtUsername.Clear();
                txtpassword.Clear();
                cbUserType.SelectedIndex = -1;

                loadData();

                MessageBox.Show("The user record is deleted successfully.");
                txtId.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            FormReturn formReturn = new FormReturn(UserType);
            formReturn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain(UserType);
            formMain.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMember formMember = new FormMember(UserType);
            formMember.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBook formBook = new FormBook(UserType);
            formBook.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStaff formStaff = new FormStaff(UserType);
            formStaff.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIssue formIssue = new FormIssue(UserType);
            formIssue.ShowDialog();
        }
    }
}
