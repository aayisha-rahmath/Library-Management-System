namespace LibraryManagementSystem
{
    partial class FormStaff
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnBooks = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "Contact:";
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(755, 162);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(109, 20);
            this.txtcontact.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 103;
            this.label1.Text = "NIC:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnic
            // 
            this.txtnic.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnic.Location = new System.Drawing.Point(568, 162);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(121, 20);
            this.txtnic.TabIndex = 102;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 180);
            this.dataGridView1.TabIndex = 101;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(409, 128);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(47, 17);
            this.lblpassword.TabIndex = 100;
            this.lblpassword.Text = "Name:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(304, 128);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(27, 17);
            this.lblusername.TabIndex = 99;
            this.lblusername.Text = "ID:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(412, 162);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 20);
            this.txtname.TabIndex = 98;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(296, 162);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(68, 20);
            this.txtid.TabIndex = 97;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(817, 331);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(125, 36);
            this.btnclear.TabIndex = 96;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(652, 331);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(125, 36);
            this.btndelete.TabIndex = 95;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnedit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(497, 331);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(125, 36);
            this.btnedit.TabIndex = 94;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(331, 331);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(125, 36);
            this.btnsave.TabIndex = 93;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(85, 514);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(134, 43);
            this.btnlogout.TabIndex = 92;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 91;
            this.label4.Text = "Staff Details";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(85, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 43);
            this.button5.TabIndex = 90;
            this.button5.Text = "Staff";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(85, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 43);
            this.button4.TabIndex = 89;
            this.button4.Text = "Book Return";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(85, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 43);
            this.button3.TabIndex = 88;
            this.button3.Text = "Book Issue";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(85, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 43);
            this.button2.TabIndex = 87;
            this.button2.Text = "Members";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnhome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(85, 98);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(134, 43);
            this.btnhome.TabIndex = 86;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 85;
            this.label3.Text = "Readerware";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(635, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 115;
            this.label6.Text = "Date Joined :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 113;
            this.label5.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(456, 254);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(121, 20);
            this.txtemail.TabIndex = 112;
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBooks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.Location = new System.Drawing.Point(85, 219);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(134, 43);
            this.btnBooks.TabIndex = 116;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(652, 251);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 117;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 9, 13, 24, 52, 0);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 616);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStaff";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}