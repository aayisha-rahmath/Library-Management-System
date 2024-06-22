namespace LibraryManagementSystem
{
    partial class FormReturn
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
            this.cbmemberid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbooktitle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblusertype = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.cbbookid = new System.Windows.Forms.ComboBox();
            this.txtmembername = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbookreturn = new System.Windows.Forms.Button();
            this.btnbookissue = new System.Windows.Forms.Button();
            this.btnmember = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnbook = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnstaff = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmemberid
            // 
            this.cbmemberid.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmemberid.FormattingEnabled = true;
            this.cbmemberid.Location = new System.Drawing.Point(295, 155);
            this.cbmemberid.Name = "cbmemberid";
            this.cbmemberid.Size = new System.Drawing.Size(69, 22);
            this.cbmemberid.TabIndex = 99;
            this.cbmemberid.SelectedIndexChanged += new System.EventHandler(this.cbmemberid_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 98;
            this.label6.Text = "Issue Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 96;
            this.label2.Text = "Book Title:";
            // 
            // txtbooktitle
            // 
            this.txtbooktitle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbooktitle.Location = new System.Drawing.Point(696, 155);
            this.txtbooktitle.Name = "txtbooktitle";
            this.txtbooktitle.Size = new System.Drawing.Size(170, 20);
            this.txtbooktitle.TabIndex = 95;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 287);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // lblusertype
            // 
            this.lblusertype.AutoSize = true;
            this.lblusertype.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusertype.Location = new System.Drawing.Point(550, 121);
            this.lblusertype.Name = "lblusertype";
            this.lblusertype.Size = new System.Drawing.Size(58, 17);
            this.lblusertype.TabIndex = 93;
            this.lblusertype.Text = "Book Id:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(397, 121);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(101, 17);
            this.lblpassword.TabIndex = 92;
            this.lblpassword.Text = "Member Name:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(292, 121);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(81, 17);
            this.lblusername.TabIndex = 91;
            this.lblusername.Text = "Member ID:";
            // 
            // cbbookid
            // 
            this.cbbookid.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbookid.FormattingEnabled = true;
            this.cbbookid.Location = new System.Drawing.Point(553, 152);
            this.cbbookid.Name = "cbbookid";
            this.cbbookid.Size = new System.Drawing.Size(94, 22);
            this.cbbookid.TabIndex = 90;
            this.cbbookid.SelectedIndexChanged += new System.EventHandler(this.cbbookid_SelectedIndexChanged);
            // 
            // txtmembername
            // 
            this.txtmembername.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmembername.Location = new System.Drawing.Point(400, 155);
            this.txtmembername.Name = "txtmembername";
            this.txtmembername.Size = new System.Drawing.Size(121, 20);
            this.txtmembername.TabIndex = 89;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(604, 282);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(125, 36);
            this.btnclear.TabIndex = 88;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnreturn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Location = new System.Drawing.Point(396, 282);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(125, 36);
            this.btnreturn.TabIndex = 86;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(48, 549);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(134, 43);
            this.btnlogout.TabIndex = 85;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "Return Details";
            // 
            // btnbookreturn
            // 
            this.btnbookreturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbookreturn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookreturn.Location = new System.Drawing.Point(48, 420);
            this.btnbookreturn.Name = "btnbookreturn";
            this.btnbookreturn.Size = new System.Drawing.Size(134, 43);
            this.btnbookreturn.TabIndex = 82;
            this.btnbookreturn.Text = "Book Return";
            this.btnbookreturn.UseVisualStyleBackColor = false;
            this.btnbookreturn.Click += new System.EventHandler(this.btnbookreturn_Click);
            // 
            // btnbookissue
            // 
            this.btnbookissue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnbookissue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookissue.Location = new System.Drawing.Point(48, 358);
            this.btnbookissue.Name = "btnbookissue";
            this.btnbookissue.Size = new System.Drawing.Size(134, 43);
            this.btnbookissue.TabIndex = 81;
            this.btnbookissue.Text = "Book Issue";
            this.btnbookissue.UseVisualStyleBackColor = false;
            this.btnbookissue.Click += new System.EventHandler(this.btnbookissue_Click);
            // 
            // btnmember
            // 
            this.btnmember.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnmember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmember.Location = new System.Drawing.Point(48, 181);
            this.btnmember.Name = "btnmember";
            this.btnmember.Size = new System.Drawing.Size(134, 43);
            this.btnmember.TabIndex = 80;
            this.btnmember.Text = "Members";
            this.btnmember.UseVisualStyleBackColor = false;
            this.btnmember.Click += new System.EventHandler(this.btnmember_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 43);
            this.button1.TabIndex = 79;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "Return Date:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(622, 355);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(359, 287);
            this.dataGridView2.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 14);
            this.label7.TabIndex = 106;
            this.label7.Text = "<< Book Issued >>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(753, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 14);
            this.label8.TabIndex = 107;
            this.label8.Text = "<< Book Returned >>";
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnbook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.Location = new System.Drawing.Point(48, 237);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(134, 43);
            this.btnbook.TabIndex = 108;
            this.btnbook.Text = "Books";
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(343, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 109;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 9, 13, 24, 52, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(525, 226);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker2.TabIndex = 110;
            this.dateTimePicker2.Value = new System.DateTime(2024, 6, 9, 13, 24, 52, 0);
            // 
            // btnstaff
            // 
            this.btnstaff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnstaff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaff.Location = new System.Drawing.Point(48, 297);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(134, 43);
            this.btnstaff.TabIndex = 83;
            this.btnstaff.Text = "Staff";
            this.btnstaff.UseVisualStyleBackColor = false;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 111;
            this.label3.Text = "Readerware";
            // 
            // FormReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 656);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmemberid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbooktitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblusertype);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.cbbookid);
            this.Controls.Add(this.txtmembername);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnstaff);
            this.Controls.Add(this.btnbookreturn);
            this.Controls.Add(this.btnbookissue);
            this.Controls.Add(this.btnmember);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReturn";
            this.Load += new System.EventHandler(this.FormReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmemberid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbooktitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblusertype;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.ComboBox cbbookid;
        private System.Windows.Forms.TextBox txtmembername;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnbookreturn;
        private System.Windows.Forms.Button btnbookissue;
        private System.Windows.Forms.Button btnmember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnstaff;
        private System.Windows.Forms.Label label3;
    }
}