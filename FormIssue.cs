using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace LibraryManagementSystem
{
    public partial class FormIssue : Form
    {
        MySqlConnection conn = new MySqlConnection(db.connectionString);
        public string UserType { get; set; }
        public FormIssue(string userType)
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

            }
            else
            {
                btnsave.Visible = true;
                btnedit.Visible = true;
                btnclear.Visible = true;
            }
        }        

        private void LoadData()
        {
            try
            {
                conn.Open();

                BindingSource bsource = new BindingSource();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM librarydb.tblissue", conn);
                adapter.Fill(table);
                bsource.DataSource = table;
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FillStudent()
        {
            conn = new MySqlConnection(db.connectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT MemberId FROM tblmember", conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Columns.Add("MemberId", typeof(int));

                dt.Load(rdr);

                cbmemberid.ValueMember = "MemberId";
                cbmemberid.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FillBook()
        {
            conn = new MySqlConnection(db.connectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT bookid FROM tblbooks", conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Columns.Add("bookid", typeof(int));

                dt.Load(rdr);

                cbbookid.ValueMember = "bookid";
                cbbookid.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Method to retrieve the member name from the database
        private string GetMemberName(string memberID)
        {
            conn = new MySqlConnection(db.connectionString);
            try
            {
                conn.Open();

                // Create the command
                MySqlCommand cmd = new MySqlCommand("SELECT Name FROM tblmember WHERE MemberId = @MemberId", conn);

                // Add the parameter
                cmd.Parameters.AddWithValue("@MemberId", memberID);

                // Execute the command
                object result = cmd.ExecuteScalar();

                // Return the member name
                return result != null ? result.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                // Handle any errors
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
            finally
            {
                conn.Close();
            }
        }


        // Method to retrieve the book title from the database
        private string GetBookName(string bookId)
        {
            conn = new MySqlConnection(db.connectionString);
            try
            {
                conn.Open();

                // Create the command
                MySqlCommand cmd = new MySqlCommand("SELECT title FROM tblbooks WHERE bookid = @bookid", conn);

                // Add the parameter
                cmd.Parameters.AddWithValue("@bookid", bookId);

                // Execute the command
                object result = cmd.ExecuteScalar();

                // Return the member name
                return result != null ? result.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                // Handle any errors
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
            finally
            {
                conn.Close();
            }
        }

        
        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain(UserType);
            formMain.ShowDialog();
            
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook(UserType);
            formBook.ShowDialog();
            this.Hide();
        }

        // This function is for counting the total amount of book a student can borrow (and the max limit is 5)
        int number = 0;
        public void countBook()
        {
            conn = new MySqlConnection(db.connectionString);
            try
            {
                conn.Open();
                string Query = "SELECT count(*) FROM tblissue WHERE MemberId = @MemberId";
                MySqlCommand command = new MySqlCommand(Query, conn);
                command.Parameters.AddWithValue("@MemberId", cbmemberid.SelectedValue.ToString());
                number = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            countBook();

            if (number == 5)
            {
                MessageBox.Show("Student can't borrow more than 5 books!");
            }
            else if (!string.IsNullOrEmpty(txtname.Text) || !string.IsNullOrEmpty(txtbooktitle.Text))
            {
                conn = new MySqlConnection(db.connectionString);
                try
                {
                    conn.Open();
                    string insertQuery;
                    insertQuery = "INSERT INTO `librarydb`.`tblissue`(`MemberId`, `MemberName`, `bookId`, `bookTitle`, `IssueDate`) VALUES (@MemberId, @MemberName, @bookId, @bookTitle, @IssueDate)";
                    MySqlCommand command = new MySqlCommand(insertQuery, conn);
                    command.Parameters.AddWithValue("@MemberId", cbmemberid.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@MemberName", txtname.Text);
                    command.Parameters.AddWithValue("@bookId", cbbookid.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@bookTitle", txtbooktitle.Text);
                    command.Parameters.AddWithValue("@IssueDate", dateTimePicker1.Text); // Consider using IssueDate.Value.ToString("yyyy-MM-dd") if IssueDate is a DateTimePicker control

                    command.ExecuteNonQuery();
                    conn.Close();

                    cbmemberid.ResetText();
                    txtname.Clear();
                    cbbookid.ResetText();
                    txtbooktitle.Clear();
                    dateTimePicker1.ResetText();
                    LoadData();

                    MessageBox.Show("A book is issued!");
                    txtbooktitle.Select();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the text fields!");
                cbmemberid.Select();
            }

        }

        private void cbmemberid_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbbookid_SelectionChangeCommitted(object sender, EventArgs e)
        {


        }

        private void FormIssue_Load(object sender, EventArgs e)
        {
            LoadData();
            FillStudent();
            FillBook();
            cbmemberid.SelectedIndex = -1;
            cbbookid.SelectedIndex = -1;
            txtname.Clear();
            txtbooktitle.Clear();
            dateTimePicker1.ResetText();
        }

        private void cbmemberid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmemberid.SelectedItem != null)
            {
                // Get the selected member ID
                string selectedMemberID = ((DataRowView)cbmemberid.SelectedItem)["MemberId"].ToString();

                // Retrieve the corresponding member name from the database
                string memberName = GetMemberName(selectedMemberID);

                // Display the member name in the member name textbox
                txtname.Text = memberName;
            }
        }

        private void cbbookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbookid.SelectedItem != null)
            {
                // Get the selected member ID
                string selectedBookID = ((DataRowView)cbbookid.SelectedItem)["bookid"].ToString();

                // Retrieve the corresponding member name from the database
                string bookName = GetBookName(selectedBookID);

                // Display the member name in the member name textbox
                txtbooktitle.Text = bookName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cbmemberid.SelectedIndex = -1;
            txtname.Clear();
            cbbookid.SelectedIndex = -1;
            txtbooktitle.Clear();
            dateTimePicker1.ResetText();

        }

        int key = 0;

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery;
                conn.Open();
                updateQuery = "UPDATE `librarydb`.`tblissue` SET `MemberId` = " + cbmemberid.SelectedValue.ToString() + ", `MemberName` = '" + txtname.Text + "', `bookId` = " + cbbookid.SelectedValue.ToString() + ", `bookTitle` = '" + txtbooktitle.Text + "', `IssueDate` = '" + dateTimePicker1.Text + "' WHERE  (`Issue_ID` = '" + key + "');";
                MySqlCommand command = new MySqlCommand(updateQuery, conn);
                MySqlDataReader render = command.ExecuteReader();
                conn.Close();
                cbmemberid.ResetText();
                txtname.Clear();
                cbbookid.ResetText();
                txtbooktitle.Clear();
                dateTimePicker1.ResetText();
                LoadData();
                MessageBox.Show("The issue record is updated.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells[1].Value != null && !string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                {
                    cbmemberid.SelectedValue = row.Cells[1].Value.ToString();
                }
                else
                {
                    cbmemberid.SelectedIndex = -1; // Reset if the value is not valid
                }

                if (row.Cells[2].Value != null)
                {
                    txtname.Text = row.Cells[2].Value.ToString();
                }
                else
                {
                    txtname.Clear(); // Clear if the value is not valid
                }

                if (row.Cells[3].Value != null && !string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
                {
                    cbbookid.SelectedValue = row.Cells[3].Value.ToString();
                }
                else
                {
                    cbbookid.SelectedIndex = -1; // Reset if the value is not valid
                }

                if (row.Cells[4].Value != null)
                {
                    txtbooktitle.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    txtbooktitle.Clear(); // Clear if the value is not valid
                }

                if (row.Cells[5].Value != null)
                {
                    string yearString = row.Cells[5].Value.ToString();
                    DateTime issueDate;

                    if (DateTime.TryParseExact(yearString, "yyyy", null, System.Globalization.DateTimeStyles.None, out issueDate))
                    {
                        dateTimePicker1.Value = issueDate;
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Now; // or any default value
                        //MessageBox.Show("Invalid date format in the data.");
                    }
                }

                if (string.IsNullOrEmpty(txtname.Text))
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }

        }

        private void btnmember_Click(object sender, EventArgs e)
        {
            FormMember formMember = new FormMember(UserType);
            formMember.ShowDialog();
            this.Hide();
        }

        private void btnstafff_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStaff formStaff = new FormStaff(UserType);
            formStaff.ShowDialog();
        }

        private void btnbookreturn_Click(object sender, EventArgs e)
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
