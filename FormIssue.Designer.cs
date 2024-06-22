namespace LibraryManagementSystem
{
    partial class FormIssue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbooktitle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblusertype = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.cbbookid = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbookreturn = new System.Windows.Forms.Button();
            this.btnbookissue = new System.Windows.Forms.Button();
            this.btnmember = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmemberid = new System.Windows.Forms.ComboBox();
            this.btnBooks = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnstafff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(867, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Issue Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(685, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Book Title";
            // 
            // txtbooktitle
            // 
            this.txtbooktitle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbooktitle.Location = new System.Drawing.Point(688, 176);
            this.txtbooktitle.Name = "txtbooktitle";
            this.txtbooktitle.Size = new System.Drawing.Size(147, 20);
            this.txtbooktitle.TabIndex = 71;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 268);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // lblusertype
            // 
            this.lblusertype.AutoSize = true;
            this.lblusertype.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusertype.Location = new System.Drawing.Point(557, 142);
            this.lblusertype.Name = "lblusertype";
            this.lblusertype.Size = new System.Drawing.Size(58, 17);
            this.lblusertype.TabIndex = 67;
            this.lblusertype.Text = "Book Id:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(404, 142);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(101, 17);
            this.lblpassword.TabIndex = 66;
            this.lblpassword.Text = "Member Name:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(299, 142);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(81, 17);
            this.lblusername.TabIndex = 65;
            this.lblusername.Text = "Member ID:";
            // 
            // cbbookid
            // 
            this.cbbookid.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbookid.FormattingEnabled = true;
            this.cbbookid.Location = new System.Drawing.Point(560, 173);
            this.cbbookid.Name = "cbbookid";
            this.cbbookid.Size = new System.Drawing.Size(94, 22);
            this.cbbookid.TabIndex = 64;
            this.cbbookid.SelectedIndexChanged += new System.EventHandler(this.cbbookid_SelectedIndexChanged);
            this.cbbookid.SelectionChangeCommitted += new System.EventHandler(this.cbbookid_SelectionChangeCommitted);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(407, 176);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 20);
            this.txtname.TabIndex = 63;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(725, 241);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(125, 36);
            this.btnclear.TabIndex = 60;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnedit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(570, 241);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(125, 36);
            this.btnedit.TabIndex = 59;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(406, 241);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(125, 36);
            this.btnsave.TabIndex = 58;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(80, 548);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(134, 43);
            this.btnlogout.TabIndex = 57;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "Issue Details";
            // 
            // btnbookreturn
            // 
            this.btnbookreturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnbookreturn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookreturn.Location = new System.Drawing.Point(80, 454);
            this.btnbookreturn.Name = "btnbookreturn";
            this.btnbookreturn.Size = new System.Drawing.Size(134, 43);
            this.btnbookreturn.TabIndex = 54;
            this.btnbookreturn.Text = "Book Return";
            this.btnbookreturn.UseVisualStyleBackColor = false;
            this.btnbookreturn.Click += new System.EventHandler(this.btnbookreturn_Click);
            // 
            // btnbookissue
            // 
            this.btnbookissue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbookissue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookissue.Location = new System.Drawing.Point(80, 390);
            this.btnbookissue.Name = "btnbookissue";
            this.btnbookissue.Size = new System.Drawing.Size(134, 43);
            this.btnbookissue.TabIndex = 53;
            this.btnbookissue.Text = "Book Issue";
            this.btnbookissue.UseVisualStyleBackColor = false;
            // 
            // btnmember
            // 
            this.btnmember.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnmember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmember.Location = new System.Drawing.Point(80, 192);
            this.btnmember.Name = "btnmember";
            this.btnmember.Size = new System.Drawing.Size(134, 43);
            this.btnmember.TabIndex = 52;
            this.btnmember.Text = "Members";
            this.btnmember.UseVisualStyleBackColor = false;
            this.btnmember.Click += new System.EventHandler(this.btnmember_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnhome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(80, 128);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(134, 43);
            this.btnhome.TabIndex = 51;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Readerware";
            // 
            // cbmemberid
            // 
            this.cbmemberid.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmemberid.FormattingEnabled = true;
            this.cbmemberid.Location = new System.Drawing.Point(302, 176);
            this.cbmemberid.Name = "cbmemberid";
            this.cbmemberid.Size = new System.Drawing.Size(69, 22);
            this.cbmemberid.TabIndex = 77;
            this.cbmemberid.SelectedIndexChanged += new System.EventHandler(this.cbmemberid_SelectedIndexChanged);
            this.cbmemberid.SelectionChangeCommitted += new System.EventHandler(this.cbmemberid_SelectionChangeCommitted);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBooks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.Location = new System.Drawing.Point(80, 258);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(134, 43);
            this.btnBooks.TabIndex = 78;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(870, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 79;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 9, 13, 24, 52, 0);
            // 
            // btnstafff
            // 
            this.btnstafff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnstafff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstafff.Location = new System.Drawing.Point(80, 324);
            this.btnstafff.Name = "btnstafff";
            this.btnstafff.Size = new System.Drawing.Size(134, 43);
            this.btnstafff.TabIndex = 55;
            this.btnstafff.Text = "Staff";
            this.btnstafff.UseVisualStyleBackColor = false;
            this.btnstafff.Click += new System.EventHandler(this.btnstafff_Click);
            // 
            // FormIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 615);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.cbmemberid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbooktitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblusertype);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.cbbookid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnstafff);
            this.Controls.Add(this.btnbookreturn);
            this.Controls.Add(this.btnbookissue);
            this.Controls.Add(this.btnmember);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIssue";
            this.Load += new System.EventHandler(this.FormIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbooktitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblusertype;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.ComboBox cbbookid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnbookreturn;
        private System.Windows.Forms.Button btnbookissue;
        private System.Windows.Forms.Button btnmember;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmemberid;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnstafff;
    }
}