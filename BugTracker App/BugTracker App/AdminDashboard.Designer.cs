namespace BugTrackerApp
{
    partial class adminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            this.search = new System.Windows.Forms.Button();
            this.userType = new System.Windows.Forms.Button();
            this.fixedBug = new System.Windows.Forms.Button();
            this.unfixedBug = new System.Windows.Forms.Button();
            this.newUser = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(59, 83);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(137, 25);
            this.search.TabIndex = 0;
            this.search.Text = "Search here";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // userType
            // 
            this.userType.Location = new System.Drawing.Point(59, 134);
            this.userType.Margin = new System.Windows.Forms.Padding(2);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(137, 25);
            this.userType.TabIndex = 1;
            this.userType.Text = "User Type";
            this.userType.UseVisualStyleBackColor = true;
            this.userType.Click += new System.EventHandler(this.userType_Click);
            // 
            // fixedBug
            // 
            this.fixedBug.Location = new System.Drawing.Point(61, 182);
            this.fixedBug.Margin = new System.Windows.Forms.Padding(2);
            this.fixedBug.Name = "fixedBug";
            this.fixedBug.Size = new System.Drawing.Size(135, 25);
            this.fixedBug.TabIndex = 2;
            this.fixedBug.Text = "History(Fixed Bug);";
            this.fixedBug.UseVisualStyleBackColor = true;
            this.fixedBug.Click += new System.EventHandler(this.fixedBug_Click);
            // 
            // unfixedBug
            // 
            this.unfixedBug.Location = new System.Drawing.Point(59, 228);
            this.unfixedBug.Margin = new System.Windows.Forms.Padding(2);
            this.unfixedBug.Name = "unfixedBug";
            this.unfixedBug.Size = new System.Drawing.Size(137, 27);
            this.unfixedBug.TabIndex = 3;
            this.unfixedBug.Text = "History(Unfinished Bug)";
            this.unfixedBug.UseVisualStyleBackColor = true;
            this.unfixedBug.Click += new System.EventHandler(this.unfixedBug_Click);
            // 
            // newUser
            // 
            this.newUser.Location = new System.Drawing.Point(59, 278);
            this.newUser.Margin = new System.Windows.Forms.Padding(2);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(135, 19);
            this.newUser.TabIndex = 4;
            this.newUser.Text = "Add New User";
            this.newUser.UseVisualStyleBackColor = true;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(78, 372);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(63, 24);
            this.close.TabIndex = 6;
            this.close.Text = "Log Out";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Export All Bug To Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(78, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 75);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Admin Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(252, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.unfixedBug);
            this.Controls.Add(this.fixedBug);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.search);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button userType;
        private System.Windows.Forms.Button fixedBug;
        private System.Windows.Forms.Button unfixedBug;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}