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
    public partial class fixedHistoryDeveloper : Form
    {
        connection conn = new connection();
        gettersANDsetters getandset = new gettersANDsetters();
        public fixedHistoryDeveloper()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void displayBug()
        {
            string query = "select * from bug where developerId = " + getandset.getId() ;
            DataTable dt = conn.retrieve(query);
            dataGridView1.DataSource = dt;
        }
        private void fixedHistoryDeveloper_Load(object sender, EventArgs e)
        {
            displayBug();
        }
    }
}
