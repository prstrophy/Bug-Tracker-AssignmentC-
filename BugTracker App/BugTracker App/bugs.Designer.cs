namespace BugTrackerApp
{
    partial class bugs
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
            this.idBug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TesterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeveloperId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeveloperCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBug,
            this.TesterId,
            this.LineNo,
            this.Method,
            this.Class,
            this.Description,
            this.Status,
            this.DeveloperId,
            this.DeveloperCommand,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 563);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idBug
            // 
            this.idBug.DataPropertyName = "bugId";
            this.idBug.HeaderText = "Bug Id";
            this.idBug.Name = "idBug";
            // 
            // TesterId
            // 
            this.TesterId.DataPropertyName = "testerId";
            this.TesterId.HeaderText = "Tester Id";
            this.TesterId.Name = "TesterId";
            // 
            // LineNo
            // 
            this.LineNo.DataPropertyName = "lineNum";
            this.LineNo.HeaderText = "Line no";
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
            // Status
            // 
            this.Status.DataPropertyName = "fixStatus";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // DeveloperId
            // 
            this.DeveloperId.DataPropertyName = "developerId";
            this.DeveloperId.HeaderText = "Developer Id";
            this.DeveloperId.Name = "DeveloperId";
            // 
            // DeveloperCommand
            // 
            this.DeveloperCommand.DataPropertyName = "developerCmd";
            this.DeveloperCommand.HeaderText = "Developer Command";
            this.DeveloperCommand.Name = "DeveloperCommand";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "bugReportedDate";
            this.Column2.HeaderText = "Bug Reported Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "bugFixedDate";
            this.Column3.HeaderText = "Bug Fixed Date";
            this.Column3.Name = "Column3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Export To Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 727);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "allBug";
            this.Text = "allBug";
            this.Load += new System.EventHandler(this.allBug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBug;
        private System.Windows.Forms.DataGridViewTextBoxColumn TesterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeveloperId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeveloperCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
    }
}