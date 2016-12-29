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
    public partial class bughistory : Form
    {
        connection conn = new connection();
        gettersANDsetters getandset = new gettersANDsetters();
        public bughistory()
        {
            InitializeComponent();
        }

        private void bugTriedHistory_Load(object sender, EventArgs e)
        {
            displayparticularBug();
        }
        public void displayparticularBug()
        {
            label1.Text = Convert.ToString(getandset.getbugId());
            string query = "SELECT * FROM bugTried WHERE bugId='" + getandset.getbugId() + "' ";
            DataTable dt = conn.retrieve(query);
            dataGridView1.DataSource = dt;
        }

    }
}
