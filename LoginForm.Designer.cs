namespace LibraryManagementSystem
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cbusertype = new System.Windows.Forms.ComboBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusertype = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Ivory;
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(120, 337);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 38);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(251, 139);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(179, 23);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(251, 184);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(179, 23);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // cbusertype
            // 
            this.cbusertype.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbusertype.FormattingEnabled = true;
            this.cbusertype.Items.AddRange(new object[] {
            "Admin",
            "Librarian"});
            this.cbusertype.Location = new System.Drawing.Point(251, 232);
            this.cbusertype.Name = "cbusertype";
            this.cbusertype.Size = new System.Drawing.Size(179, 24);
            this.cbusertype.TabIndex = 3;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(134, 139);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(99, 18);
            this.lblusername.TabIndex = 4;
            this.lblusername.Text = "Username :";
            this.lblusername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(134, 184);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(94, 18);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Password :";
            // 
            // lblusertype
            // 
            this.lblusertype.AutoSize = true;
            this.lblusertype.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusertype.Location = new System.Drawing.Point(134, 232);
            this.lblusertype.Name = "lblusertype";
            this.lblusertype.Size = new System.Drawing.Size(100, 18);
            this.lblusertype.TabIndex = 6;
            this.lblusertype.Text = "User Type :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(114, 52);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(363, 32);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Library Management System";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(303, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(563, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblusertype);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.cbusertype);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cbusertype;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusertype;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button1;
    }
}

