namespace BugTrackerApp
{
    partial class TesterDashboard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BugId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TesterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeveloperId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeveloperMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BugReportedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BugFixedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linenumber = new System.Windows.Forms.TextBox();
            this.methodname = new System.Windows.Forms.TextBox();
            this.classname = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BugId,
            this.TesterId,
            this.LineNo,
            this.Method,
            this.Class,
            this.Description,
            this.FixStatus,
            this.DeveloperId,
            this.DeveloperMessage,
            this.BugReportedDate,
            this.BugFixedDate,
            this.Update});
            this.dataGridView1.Location = new System.Drawing.Point(24, 266);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(697, 194);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BugId
            // 
            this.BugId.DataPropertyName = "bugId";
            this.BugId.HeaderText = "BugId";
            this.BugId.Name = "BugId";
            // 
            // TesterId
            // 
            this.TesterId.DataPropertyName = "testerId";
            this.TesterId.HeaderText = "TesterId";
            this.TesterId.Name = "TesterId";
            // 
            // LineNo
            // 
            this.LineNo.DataPropertyName = "lineNum";
            this.LineNo.HeaderText = "Line No";
            this.LineNo.Name = "LineNo";
            // 
            // Method
            // 
            this.Method.DataPropertyName = "method";
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            // 
            // Class
            // 
            this.Class.DataPropertyName = "class";
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // FixStatus
            // 
            this.FixStatus.DataPropertyName = "fixStatus";
            this.FixStatus.HeaderText = "FixStatus";
            this.FixStatus.Name = "FixStatus";
            // 
            // DeveloperId
            // 
            this.DeveloperId.DataPropertyName = "developerId";
            this.DeveloperId.HeaderText = "DeveloperId";
            this.DeveloperId.Name = "DeveloperId";
            // 
            // DeveloperMessage
            // 
            this.DeveloperMessage.DataPropertyName = "developerCmd";
            this.DeveloperMessage.HeaderText = "DeveloperMessage";
            this.DeveloperMessage.Name = "DeveloperMessage";
            // 
            // BugReportedDate
            // 
            this.BugReportedDate.DataPropertyName = "bugReportedDate";
            this.BugReportedDate.HeaderText = "Bug Reported Date";
            this.BugReportedDate.Name = "BugReportedDate";
            // 
            // BugFixedDate
            // 
            this.BugFixedDate.DataPropertyName = "bugFixedDate";
            this.BugFixedDate.HeaderText = "Bug Fixed Date";
            this.BugFixedDate.Name = "BugFixedDate";
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForLinkValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Line No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Method Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // linenumber
            // 
            this.linenumber.Location = new System.Drawing.Point(213, 71);
            this.linenumber.Margin = new System.Windows.Forms.Padding(2);
            this.linenumber.Name = "linenumber";
            this.linenumber.Size = new System.Drawing.Size(68, 20);
            this.linenumber.TabIndex = 6;
            this.linenumber.TextChanged += new System.EventHandler(this.linenumber_TextChanged);
            // 
            // methodname
            // 
            this.methodname.Location = new System.Drawing.Point(213, 102);
            this.methodname.Margin = new System.Windows.Forms.Padding(2);
            this.methodname.Name = "methodname";
            this.methodname.Size = new System.Drawing.Size(68, 20);
            this.methodname.TabIndex = 7;
            this.methodname.TextChanged += new System.EventHandler(this.methodname_TextChanged);
            // 
            // classname
            // 
            this.classname.Location = new System.Drawing.Point(213, 129);
            this.classname.Margin = new System.Windows.Forms.Padding(2);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(68, 20);
            this.classname.TabIndex = 8;
            this.classname.TextChanged += new System.EventHandler(this.classname_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(213, 165);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(169, 77);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(445, 218);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(55, 22);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 22);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Fix Error";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(178, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 54);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tester Dashboard.";
            // 
            // TesterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.methodname);
            this.Controls.Add(this.linenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TesterDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardForTester";
            this.Load += new System.EventHandler(this.dashboardForTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox linenumber;
        private System.Windows.Forms.TextBox methodname;
        private System.Windows.Forms.TextBox classname;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BugId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TesterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeveloperId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeveloperMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn BugReportedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BugFixedDate;
        private System.Windows.Forms.DataGridViewLinkColumn Update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}