namespace BugTrackerApp
{
    partial class bughistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bugId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug ::";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bugId,
            this.devid,
            this.testid,
            this.bugStat});
            this.dataGridView1.Location = new System.Drawing.Point(8, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(448, 162);
            this.dataGridView1.TabIndex = 1;
            // 
            // bugId
            // 
            this.bugId.DataPropertyName = "bugid";
            this.bugId.HeaderText = "Bug Id";
            this.bugId.Name = "bugId";
            // 
            // devid
            // 
            this.devid.DataPropertyName = "developerid";
            this.devid.HeaderText = "DeveloperId";
            this.devid.Name = "devid";
            // 
            // testid
            // 
            this.testid.DataPropertyName = "testerid";
            this.testid.HeaderText = "Tester Id";
            this.testid.Name = "testid";
            // 
            // bugStat
            // 
            this.bugStat.DataPropertyName = "bugstatus";
            this.bugStat.HeaderText = "Bug Status";
            this.bugStat.Name = "bugStat";
            // 
            // bughistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 306);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "bughistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bugTriedHistory";
            this.Load += new System.EventHandler(this.bugTriedHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugId;
        private System.Windows.Forms.DataGridViewTextBoxColumn devid;
        private System.Windows.Forms.DataGridViewTextBoxColumn testid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugStat;
    }
}