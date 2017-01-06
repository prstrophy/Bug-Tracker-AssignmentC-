using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace BugTrackerApp
{
    public partial class DeveloperDashboard : Form
    {
        connection conn = new connection();
        gettersANDsetters getandset = new gettersANDsetters();
        int BugId;
        public DeveloperDashboard()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                if (dataGridView1.CurrentCell.Value.ToString() == "Update")
                {
                    string bugStatus = Convert.ToString(dataGridView1.CurrentRow.Cells["Status"].Value);
                    if (bugStatus == "Fixed")
                    {
                        MessageBox.Show("Bug Fixed Already!!");
                    }
                    else
                    {
                        BugId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idBug"].Value);
                        string query = "select fixStatus,developerCmd from bug where bugId = " + BugId;
                        DataTable dt = conn.retrieve(query);
                        comboBox1.Text = dt.Rows[0][0].ToString();
                        richTextBox1.Text = dt.Rows[0][1].ToString();
                    label6.Text = BugId.ToString();
                }
                    

                }
                if (dataGridView1.CurrentCell.Value.ToString() == "Coudn'tSolve")
                {
                    string bugStatus = Convert.ToString(dataGridView1.CurrentRow.Cells["Status"].Value);
                    if (bugStatus == "Fixed")
                    {
                        MessageBox.Show("Bug Fixed Already!!");
                    }
                    else
                    {
                        int BugeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idBug"].Value);

                        int testerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TesterId"].Value);

                        string status = Convert.ToString(dataGridView1.CurrentRow.Cells["Status"].Value);

                        string quer = "insert into bugTried(bugid,developerid,testerid,bugstatus) values('" + BugeId + "','" + getandset.getId() + "','" + testerId + "','" + status + "')";
                        conn.manipulate(quer);
                        MessageBox.Show("Got it!!");
                    }

                }
                if (dataGridView1.CurrentCell.Value.ToString() == "bugHistory")
                {
                    int BugeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idBug"].Value);
                    getandset.setbugId(BugeId);
                    bughistory bth = new bughistory();
                    bth.Show();
                }
            
            displayBug();
            
            
        }
        public void displayBug()
        {
            string query = "select * from bug ";
            DataTable dt = conn.retrieve(query);
            dataGridView1.DataSource = dt;
        }

        private void dashboardForDeveloper_Load(object sender, EventArgs e)
        {
            displayBug();

            label5.Text = "Welcome," + getandset.getUname();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            
            
            
                string query;
                query = "UPDATE bug SET fixStatus='" + comboBox1.Text + "',developerId='" + getandset.getId() + "',developerCmd='" + richTextBox1.Text + "',bugFixedDate='" + DateTime.Now + "' WHERE bugId='" + BugId + "' ";
                conn.manipulate(query);
                displayBug();

            

                int testerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TesterId"].Value);

                string status = Convert.ToString(dataGridView1.CurrentRow.Cells["Status"].Value);

                string quer = "insert into bugTried(bugid,developerid,testerid,bugstatus) values('" + BugId + "','" + getandset.getId() + "','" + testerId + "','" + status + "')";
                conn.manipulate(quer);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void errorReporting_Click(object sender, EventArgs e)
        {
            TesterDashboard errorreportingwindow = new TesterDashboard();
            errorreportingwindow.Show();
        }

        private void errorFixedHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fixedHistoryDeveloper fhd = new fixedHistoryDeveloper();
            fhd.Show();
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.dataGridView1.Columns["Status"].Index)
                {
                    string Re = e.Value.ToString();
                    if (Re.Trim().Equals("Fixed"))
                    {
                        this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                        this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                //foreach (DataGridViewRow row in dgDetails3.Rows)
                //  foreach (DataGridViewCell cell in row.Cells)
                //  {
                // if (dgDetails3.CurrentRow.Cells["R"].Value.ToString().Trim().Equals("Fixed"))
                //  {
                //   row.DefaultCellStyle.BackColor = Color.Blue;
                // row.DefaultCellStyle.ForeColor = Color.Blue;

                //  }
            }
            catch (Exception)
            {

            }
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdetails edu = new Userdetails();
            edu.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.dataGridView1.Columns["Status"].Index)
                {
                    string Re = e.Value.ToString();
                    if (Re.Trim().Equals("Fixed"))
                    {
                        this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                        this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
