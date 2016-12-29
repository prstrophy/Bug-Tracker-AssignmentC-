namespace BugTrackerApp
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(152, 88);
            this.fname.Margin = new System.Windows.Forms.Padding(2);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(68, 20);
            this.fname.TabIndex = 4;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(420, 88);
            this.lname.Margin = new System.Windows.Forms.Padding(2);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(68, 20);
            this.lname.TabIndex = 5;
            this.lname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(152, 129);
            this.uname.Margin = new System.Windows.Forms.Padding(2);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(68, 20);
            this.uname.TabIndex = 6;
            this.uname.TextChanged += new System.EventHandler(this.uname_TextChanged);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(420, 133);
            this.pwd.Margin = new System.Windows.Forms.Padding(2);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(68, 20);
            this.pwd.TabIndex = 7;
            this.pwd.TextChanged += new System.EventHandler(this.pwd_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 166);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "User Type";
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(179, 219);
            this.signUp.Margin = new System.Windows.Forms.Padding(2);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(77, 25);
            this.signUp.TabIndex = 10;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(77, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 59);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Signup";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\";
            this.Load += new System.EventHandler(this.registrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}