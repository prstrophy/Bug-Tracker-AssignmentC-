namespace BugTrackerApp
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.uname = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username::";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password::";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(112, 148);
            this.login.Margin = new System.Windows.Forms.Padding(2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(57, 21);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(209, 73);
            this.uname.Margin = new System.Windows.Forms.Padding(2);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(68, 20);
            this.uname.TabIndex = 4;
            this.uname.TextChanged += new System.EventHandler(this.uname_TextChanged);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(209, 111);
            this.pwd.Margin = new System.Windows.Forms.Padding(2);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(68, 20);
            this.pwd.TabIndex = 5;
            this.pwd.TextChanged += new System.EventHandler(this.pwd_TextChanged);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(261, 211);
            this.signup.Margin = new System.Windows.Forms.Padding(2);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(73, 31);
            this.signup.TabIndex = 6;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(209, 148);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(56, 21);
            this.close.TabIndex = 7;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(74, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 65);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sign-In";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Not Registered? You can Register here >";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 290);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

