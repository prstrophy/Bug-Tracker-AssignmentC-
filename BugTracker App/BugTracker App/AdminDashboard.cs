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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search srch = new Search();
            srch.Show();
        }

        private void userType_Click(object sender, EventArgs e)
        {
            userType ut = new userType();
            ut.Show();
        }

        private void fixedBug_Click(object sender, EventArgs e)
        {
            fixedBugHistory fbh = new fixedBugHistory();
            fbh.Show();
        }

        private void unfixedBug_Click(object sender, EventArgs e)
        {
            unfixedHistory ufh = new unfixedHistory();
            ufh.Show();
        }

        private void newUser_Click(object sender, EventArgs e)
        {
            registrationForm rf = new registrationForm();
            rf.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bugs ab = new bugs();
            ab.Show();
        }
    }
}
