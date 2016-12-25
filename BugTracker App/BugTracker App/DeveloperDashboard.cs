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
        DBConnection conn = new DBConnection();
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
                BugId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idBug"].Value);
                string query = "select fixStatus,developerCmd from bug where bugId = " + BugId;
                DataTable dt = conn.retrieve(query);
                comboBox1.Text = dt.Rows[0][0].ToString();
                richTextBox1.Text = dt.Rows[0][1].ToString();
                
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
    }
}
