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
    public partial class fixedBugHistory : Form
    {
        gettersANDsetters getandset = new gettersANDsetters();
        connection conn = new connection();
        public fixedBugHistory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value.ToString() == "bugHistory")
            {
                int BugeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idBug"].Value);
                getandset.setbugId(BugeId);
                bughistory bth = new bughistory();
                bth.Show();
            }
        }
        public void displayBug()
        {
            string query;
            string status = "Fixed";
            query = "select * from bug where fixStatus='" + status + "'";
            DataTable dt = conn.retrieve(query);
            dataGridView1.DataSource = dt;
        }

        private void fixedBugHistory_Load(object sender, EventArgs e)
        {
            displayBug();
        }
    }
}
