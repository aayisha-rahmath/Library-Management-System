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
    public partial class FormBook : Form
    {
        MySqlConnection conn = new MySqlConnection(db.connectionString);
        public string UserType { get; set; }
        public FormBook(string userType)
        {
            InitializeComponent();
            UserType = userType;
            SetPrivileges();
        }

        private void SetPrivileges()
        {
            if (UserType == "Admin")
            {
                btnSave.Visible = false;
                btnEdit.Visible = false;
                btnClear.Visible = false;
                btnDelete.Visible = false;

            }
            else
            {
                btnSave.Visible = true;
                btnEdit.Visible = true;
                btnClear.Visible = true;
                btnDelete.Visible = true;
            }
        }

        private void LoadData()
        {
            conn.Open();
            BindingSource bsource = new BindingSource();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM librarydb.tblbooks", conn);
            adapter.Fill(table);
            bsource.DataSource = table;
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtAuthor.Text) && !string.IsNullOrEmpty(txtTotCopy.Text) && !string.IsNullOrEmpty(txtAvailableCopy.Text) && !string.IsNullOrEmpty(txtPublish.Text))
            {
                try
                {
                    // Format the date correctly
                    string date = dateTimePicker1.Value.ToString("yyyy");
                    string insertQuery;
                    conn.Open();
                    //insertQuery = "INSERT INTO `library_ms`.`books_table` (`bookID`, `bookName`, `bookAuthor`, `bookCategory`, `bookEdition`, `bookPrice`, `bookPublisher`, `bookQuantity`) VALUES ('" + txtBookID.Text + "', '" + txtBookName.Text + "', '" + txtAuthor.Text + "', '" + txtCategory.Text + "', '" + txtBookEdition.Text + "', '" + txtPrice.Text + "', '" + txtPublisher.Text + "', '" + txtQuantity.Text + "');"
                    insertQuery = "INSERT INTO `librarydb`.`tblbooks` ( `title`, `author`, `total_copies`, `available_copies`, `publisher`,`published_year`) VALUES ('" + txtTitle.Text + "', '" + txtAuthor.Text + "', '" + txtTotCopy.Text + "', '" + txtAvailableCopy.Text + "', '" + txtPublish.Text + "', '" + date + "');";
                    MySqlCommand command = new MySqlCommand(insertQuery, conn);
                    MySqlDataReader render = command.ExecuteReader();
                    conn.Close();
                    txtId.Clear();
                    txtTitle.Clear();
                    txtAuthor.Clear();
                    txtTotCopy.Clear();
                    txtAvailableCopy.Clear();
                    txtPublish.Clear();
                    LoadData();
                    MessageBox.Show("A new book is added.!");
                    txtTitle.Select();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the text fields!!!");
                txtId.Select();
            }

        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                if (MessageBox.Show("Do you want to delete this record?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string deleteQuery;
                        conn.Open();
                        deleteQuery = "DELETE FROM `librarydb`.`tblbooks` WHERE (`bookid` = '" + txtId.Text + "');";
                        MySqlCommand command = new MySqlCommand(deleteQuery, conn);
                        command.ExecuteNonQuery();
                        conn.Close();
                        txtId.Clear();
                        txtAuthor.Clear();
                        txtTitle.Clear();
                        txtAvailableCopy.Clear();
                        txtTotCopy.Clear();
                        txtPublish.Clear();
                        txtId.Select();
                        LoadData();
                        MessageBox.Show("This record is deleted...!");
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
                MessageBox.Show("Please select an item to delete!");
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value.ToString();

                if (row.Cells[1].Value != null)
                {
                    txtTitle.Text = row.Cells[1].Value.ToString();
                }
                else
                {
                    txtTitle.Clear(); // Clear if the value is not valid
                }

                if (row.Cells[2].Value != null)
                {
                    txtAuthor.Text = row.Cells[2].Value.ToString();
                }
                else
                {
                    txtAuthor.Clear(); // Clear if the value is not valid
                }

                if (row.Cells[3].Value != null)
                {
                    txtTotCopy.Text = row.Cells[3].Value.ToString();
                }
                else
                {
                    txtTotCopy.Clear(); // Clear if the value is not valid
                }

                if (row.Cells[4].Value != null)
                {
                    txtAvailableCopy.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    txtAvailableCopy.Clear(); // Clear if the value is not valid
                }

                if (row.Cells[5].Value != null)
                {
                    txtPublish.Text = row.Cells[5].Value.ToString();
                }
                else
                {
                    txtPublish.Clear(); // Clear if the value is not valid
                }

                if (row.Cells[6]?.Value != null)
                {
                    string dateString = row.Cells[6].Value.ToString();
                    if (int.TryParse(dateString, out int year))
                    {
                        dateTimePicker1.Value = new DateTime(year, 1, 1);
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Now; // or any default value
                                                              //MessageBox.Show("Invalid date format in the data.");
                    }
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now; // or any default value
                }



            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery;
                conn.Open();
                updateQuery = "UPDATE `librarydb`.`tblbooks` SET `title` = '" + txtTitle.Text + "', `author` = '" + txtAuthor.Text + "', `total_copies` = '" + txtTotCopy.Text + "', `available_copies` = '" + txtAvailableCopy.Text + "', `publisher` = '" + txtPublish.Text + "', `published_year` = '" + dateTimePicker1.Text + "' WHERE (`bookid` = '" + txtId.Text + "');";
                MySqlCommand command = new MySqlCommand(updateQuery, conn);
                command.ExecuteReader();
                conn.Close();
                txtId.Clear();
                txtTitle.Clear();
                txtAuthor.Clear();
                txtAvailableCopy.Clear();
                txtTotCopy.Clear();
                txtPublish.Clear();
                LoadData();
                MessageBox.Show("The book record is updated.!");
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
            txtAuthor.Clear();
            txtTitle.Clear();
            txtAvailableCopy.Clear();
            txtTotCopy.Clear();
            txtPublish.Clear();
            txtId.Select();
        }

       
        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStaff formStaff = new FormStaff(UserType);
            formStaff.ShowDialog();
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

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Hide();
        }
    }
}
