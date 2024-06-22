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
    public partial class FormReturn : Form
    {
        MySqlConnection conn = new MySqlConnection(db.connectionString);
        public string UserType { get; set; }
        public FormReturn(string userType)
        {
            InitializeComponent();
            UserType = userType;
            SetPrivileges();
        }

        private void SetPrivileges()
        {
            if (UserType == "Admin")
            {
                btnreturn.Visible = false;
                btnclear.Visible = false;

            }
            else
            {
                btnreturn.Visible = true;
                btnclear.Visible = true;
            }
        }

        private void LoadIssueData()
        {
            conn.Open();
            BindingSource bsource = new BindingSource();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM librarydb.tblissue", conn);
            adapter.Fill(table);
            bsource.DataSource = table;
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void LoadReturnData()
        {
            conn.Open();
            BindingSource bsource = new BindingSource();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM librarydb.tblreturn", conn);
            adapter.Fill(table);
            bsource.DataSource = table;
            dataGridView2.DataSource = table;
            conn.Close();
        }

        int key = 0;

        private void removeFromIssue()
        {
            try
            {
                string insertQuery;
                conn.Open();
                insertQuery = "DELETE FROM `librarydb`.`tblissue` WHERE `Issue_ID` = " + key;
                MySqlCommand command = new MySqlCommand(insertQuery, conn);
                MySqlDataReader render = command.ExecuteReader();
                MessageBox.Show("Issue Data removed!");
                conn.Close();

                // displayBook();
                // studentIdCb.Clear();
                // txtStudentName.Clear();
                // bookIdCb.Clear();
                // txtBookName.Clear();
                // issueDate.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain(UserType);
            formMain.Show();
            this.Hide();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbmemberid.Text) || string.IsNullOrEmpty(cbbookid.Text) || string.IsNullOrEmpty(txtmembername.Text) || string.IsNullOrEmpty(txtbooktitle.Text))
            {
                MessageBox.Show("Please fill all the text fields!!!");
            }
            else
            {
                try
                {
                    string insertQuery;
                    conn.Open();
                    insertQuery = "INSERT INTO `librarydb`.`tblreturn`(`MemberId`, `MemberName`, `bookId`, `bookTitle`, `IssueDate`, `ReturnDate`) " +
                                  "VALUES (" + cbmemberid.Text + ", '" + txtmembername.Text + "', " + cbbookid.Text + ", '" + txtbooktitle.Text + "', '" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "')";
                    MySqlCommand command = new MySqlCommand(insertQuery, conn);
                    MySqlDataReader render = command.ExecuteReader();
                    MessageBox.Show("The book is returned.");
                    conn.Close();
                    removeFromIssue();
                    LoadIssueData();
                    LoadReturnData();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }

        }

        private void btnmember_Click(object sender, EventArgs e)
        {
            FormMember formMember = new FormMember(UserType);
            formMember.ShowDialog();
            this.Hide();
        }

        private void FormReturn_Load(object sender, EventArgs e)
        {
            //LoadIssueData();
            //LoadReturnData();
            FillStudent();
            FillBook();
            Reset();
        }

        private void Reset()
        {
            cbmemberid.SelectedIndex = -1;
            cbbookid.SelectedIndex = -1;
            txtbooktitle.Text = "";
            txtmembername.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Reset();
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
                txtmembername.Text = memberName;
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            cbmemberid.SelectedValue = row.Cells[1].Value.ToString();
            txtmembername.Text = row.Cells[2].Value.ToString();
            cbbookid.SelectedValue = row.Cells[3].Value.ToString();
            txtbooktitle.Text = row.Cells[4].Value.ToString();

            string yearString = row.Cells[5].Value.ToString();
            DateTime issueDate;

            if (DateTime.TryParseExact(yearString, "yyyy", null, System.Globalization.DateTimeStyles.None, out issueDate))
            {
                dateTimePicker1.Value = issueDate;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now; // or any default value
                MessageBox.Show("Invalid date format in the data.");
            }

            if (string.IsNullOrEmpty(txtmembername.Text))
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }

        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStaff formStaff = new FormStaff(UserType);
            formStaff.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            
        }

        private void btnbookreturn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnbookissue_Click(object sender, EventArgs e)
        {
            FormIssue formIssue = new FormIssue(UserType);
            formIssue.ShowDialog();
            this.Hide();
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook(UserType);
            formBook.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
