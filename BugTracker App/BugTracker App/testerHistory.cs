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
    public partial class testerHistory : Form
    {
        connection conn = new connection();
        gettersANDsetters getandset = new gettersANDsetters();
        public testerHistory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void displayBug()
        {
            string query = "select * from bug where testerId = " + getandset.getId();
            DataTable dt = conn.retrieve(query);
            dataGridView1.DataSource = dt;
        }

        private void testerHistory_Load(object sender, EventArgs e)
        {
            displayBug();
        }
    }
}
