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
    public partial class Search : Form
    {
        connection conn = new connection();
        gettersANDsetters getandset = new gettersANDsetters();

        public Search()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static int userSearch;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                string query = "select Id,fname,lname,username,usertypeid from users where fname like '%" + textBox1.Text + "%' or  lname like '%" + textBox1.Text + "%' or username like '%" + textBox1.Text + "%'";
                DataTable dt1 = conn.retrieve(query);
                dataGridView1.DataSource = dt1;
                //search12= dt1.Rows[0][0];

                userSearch = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserId"].Value);
            }
            catch
            {
                MessageBox.Show("Sorry!! We could not match your search. Please try other name. ");
            }

        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value.ToString() == "TesterHistory")
            {
                getandset.setId(userSearch);
                testerHistory th = new testerHistory();
                th.Show();
                

            }
            if (dataGridView1.CurrentCell.Value.ToString() == "DeveloperHistory")
            {
                getandset.setId(userSearch);
                fixedHistoryDeveloper fhd = new fixedHistoryDeveloper();
                fhd.Show();

            }

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
