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
    public partial class FormStaff : Form
    {
        MySqlConnection conn = new MySqlConnection(db.connectionString);
        public string UserType { get; set; }
        public FormStaff(string userType)
        {
            InitializeComponent();
            UserType = userType;
            SetPrivileges();
        }
        
        private void SetPrivileges()
        {
            if (UserType == "Librarian")
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

            // Use DATE_FORMAT to ensure correct date format
            string query = "SELECT `Staff_ID`, `StaffName`, `NIC`, `Contact`, `Email`, DATE_FORMAT(`Joined_Date`, '%Y-%m-%d') AS `Joined_Date` FROM librarydb.tblstaff";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);
            bsource.DataSource = table;
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Format the date correctly
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string query;
                conn.Open();
                query = "INSERT INTO `librarydb`.`tblstaff` (`Staffname`, `NIC`,`Contact`,`Email`,`Joined_Date`) VALUES (@Staffname, @NIC, @Contact, @Email, @Joined_Date)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Staffname", txtname.Text);
                command.Parameters.AddWithValue("@NIC", txtnic.Text);
                command.Parameters.AddWithValue("@Contact", txtcontact.Text);
                command.Parameters.AddWithValue("@Email", txtemail.Text);
                command.Parameters.AddWithValue("@Joined_Date", date); // Consider using DateTimePicker1.Value.ToString("yyyy-MM-dd") if DateTimePicker1 is a DateTimePicker control

                command.ExecuteNonQuery();
                conn.Close();

                txtid.Clear();
                txtname.Clear();
                txtnic.Clear();
                txtemail.Clear();
                txtcontact.Clear();
                loadData();

                MessageBox.Show("Saved staff details successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }

        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            loadData();
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
                    txtname.Clear(); // Clear if the value is not valid
                }

                if (row.Cells[2].Value != null)
                {
                    txtnic.Text = row.Cells[2].Value.ToString();
                }
                else
                {
                    txtnic.Clear(); // Clear if the value is not valid
                }

               


                if (row.Cells[3].Value != null)
                {
                    txtcontact.Text = row.Cells[3].Value.ToString();
                }
                else
                {
                    txtcontact.Clear(); // Clear if the value is not valid
                }

                if (row.Cells[4].Value != null)
                {
                    txtemail.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    txtemail.Clear(); // Clear if the value is not valid
                }

                if (row.Cells[5].Value != null)
                {
                    string dateString = row.Cells[5].Value.ToString();
                    DateTime joinedDate;

                    if (DateTime.TryParse(dateString, out joinedDate))
                    {
                        dateTimePicker1.Value = joinedDate;
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Now; // or any default value
                        //MessageBox.Show("Invalid date format in the data.");
                    }
                }

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtnic.Clear();
            txtemail.Clear();
            txtcontact.Clear();
            dateTimePicker1.Value = DateTime.Now; // Reset DateTimePicker to current date
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
                        query = "DELETE FROM `librarydb`.`tblstaff` WHERE (`Staff_ID` = '" + txtid.Text + "');";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.ExecuteReader();
                        conn.Close();
                        txtid.Clear();
                        txtname.Clear();
                        txtnic.Clear();
                        txtcontact.Clear();
                        txtemail.Clear();
                        loadData(); // this function for refreshing the database
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                conn.Open();
                query = "UPDATE `librarydb`.`tblstaff` SET `Staffname` = '" + txtname.Text + "', `NIC` = '" + txtnic.Text + "', `Contact` = '" + txtcontact.Text + "', `Email` = '" + txtemail.Text + "',`Joined_Date` = '" + dateTimePicker1.Text + "' WHERE (`Staff_ID` = '" + txtid.Text + "');";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteReader();
                conn.Close();
                txtid.Clear();
                txtname.Clear();
                txtnic.Clear();
                txtemail.Clear();
                txtcontact.Clear();
                loadData(); // this function for refreshing the database
                MessageBox.Show("Edit Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }


        private void btnhome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain(UserType);
            formMain.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMember formMember = new FormMember(UserType);
            formMember.ShowDialog();
            this.Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook(UserType);
            formBook.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormIssue formIssue = new FormIssue(UserType);
            formIssue.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReturn formReturn = new FormReturn(UserType);
            formReturn.ShowDialog();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            
        }
    }
}
