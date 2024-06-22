using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class FormMember : Form
    {
        MySqlConnection conn = new MySqlConnection(db.connectionString);

        public string UserType { get; set; }
        public FormMember(string userType)
        {
            InitializeComponent();
            UserType = userType;
            SetPrivileges();
        }

        private void SetPrivileges()
        {
            if (UserType == "Admin")
            {
                btnsave.Visible = false;
                btnedit.Visible = false;
                btnclear.Visible = false;
                btndelete.Visible = false;

            }
            else
            {
                btnsave.Visible = true;
                btnedit.Visible = true;
                btnclear.Visible = true;
                btndelete.Visible = true;
            }
        }

        private void loadData()
        {
            conn.Open();
            BindingSource bsource = new BindingSource();
            DataTable table = new DataTable();
            string query = "SELECT `MemberId`, `Name`, `NIC`, `Gender`, `Contact`, `Email`, DATE_FORMAT(`Date_Joined`, '%Y-%m-%d') AS `Date_Joined` FROM librarydb.tblmember";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);
            bsource.DataSource = table;
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain(UserType);
            formMain.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormIssue formIssue = new FormIssue(UserType);
            formIssue.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReturn formReturn = new FormReturn(UserType);
            formReturn.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtname.Text))
                {
                    MessageBox.Show("Name cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNIC.Text))
                {
                    MessageBox.Show("NIC cannot be empty.");
                    return;
                }
                if (cbGender.SelectedItem == null)
                {
                    MessageBox.Show("Gender must be selected.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtContact.Text))
                {
                    MessageBox.Show("Contact cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email cannot be empty.");
                    return;
                }

                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                string query = "INSERT INTO `librarydb`.`tblmember` (`Name`, `NIC`, `Gender`, `Contact`, `Email`, `Date_Joined`) VALUES (@Name, @NIC, @Gender, @Contact, @Email, @Date_Joined)";

                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", txtname.Text);
                command.Parameters.AddWithValue("@NIC", txtNIC.Text);
                command.Parameters.AddWithValue("@Gender", cbGender.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Contact", txtContact.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Date_Joined", date);

                command.ExecuteNonQuery();

                conn.Close();

                txtid.Clear();
                txtname.Clear();
                txtNIC.Clear();
                txtEmail.Clear();
                txtContact.Clear();

                loadData();

                MessageBox.Show("Saved member details successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }


        private void FormMember_Load(object sender, EventArgs e)
        {
          
            loadData();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            
            try
            {

                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                string query = "UPDATE `librarydb`.`tblmember` SET `Name` = @Name, `NIC` = @NIC, `Gender` = @Gender, `Contact` = @Contact, `Email` = @Email, `Date_Joined` = @Date_Joined WHERE `MemberId` = @MemberId";

                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", txtname.Text);
                command.Parameters.AddWithValue("@NIC", txtNIC.Text);
                command.Parameters.AddWithValue("@Gender", cbGender.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Contact", txtContact.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Date_Joined", date);
                command.Parameters.AddWithValue("@MemberId", txtid.Text);

                command.ExecuteNonQuery();

                conn.Close();

                txtid.Clear();
                txtname.Clear();
                txtNIC.Clear();
                txtEmail.Clear();
                txtContact.Clear();

                loadData();

                MessageBox.Show("Edit Successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtid.Text = row.Cells[0].Value.ToString();

                if (row.Cells[1].Value != null)
                {
                    txtname.Text = row.Cells[1].Value.ToString();
                }
                else
                {
                    txtname.Clear();
                }

                if (row.Cells[2].Value != null)
                {
                    txtNIC.Text = row.Cells[2].Value.ToString();
                }
                else
                {
                    txtNIC.Clear(); 
                }

                if (row.Cells[3].Value != null)
                {
                    string genderValue = row.Cells[3].Value.ToString();
                    if (cbGender.Items.Contains(genderValue))
                    {
                        cbGender.SelectedItem = genderValue;
                    }
                    else
                    {
                        cbGender.SelectedIndex = -1; 
                    }
                }
                else
                {
                    cbGender.SelectedIndex = -1; 
                }


                if (row.Cells[4].Value != null)
                {
                    txtContact.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    txtContact.Clear(); 
                }

                if (row.Cells[5].Value != null)
                {
                    txtEmail.Text = row.Cells[5].Value.ToString();
                }
                else
                {
                    txtEmail.Clear();
                }

                if (row.Cells[6].Value != null)
                {
                    string dateString = row.Cells[6].Value.ToString();
                    DateTime issueDate;

                    if (DateTime.TryParse(dateString, out issueDate))
                    {
                        dateTimePicker1.Value = issueDate;
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Now; 
                    }
                }

            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtid.Text))
            {
                if (MessageBox.Show("Do you want to delete this record?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string query;
                        conn.Open();
                        query = "DELETE FROM `librarydb`.`tblmember` WHERE (`MemberId` = '" + txtid.Text + "');";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.ExecuteNonQuery();
                        conn.Close();
                        txtid.Clear();
                        txtname.Clear();
                        txtNIC.Clear();
                        txtEmail.Clear();
                        txtContact.Clear();
                        loadData(); // this function is for refreshing the database
                        MessageBox.Show("Delete Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the item");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtNIC.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            dateTimePicker1.Value = DateTime.Today; // Reset to today's date
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook(UserType);
            formBook.ShowDialog();
            this.Hide();
        }
    }
}
