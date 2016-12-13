using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class Adminlogin : Form
    {
        DatabaseConnection conn = new DatabaseConnection();
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query;
            query = " Select username from Admin WHERE username ='"+textUname.Text+"'AND password ='"+textPwd.Text+"'";
                DataTable dt = conn.retrieve(query);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Welcome to Dashboard");
            }
            else
            {
                MessageBox.Show("Either Username or Password is Incorrect");
            }

        }

        private void textUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
