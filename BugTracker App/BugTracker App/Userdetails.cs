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
    public partial class Userdetails : Form
    {
        connection conn = new connection();
        gettersANDsetters getandset = new gettersANDsetters();
        public Userdetails()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string query = "UPDATE users SET fname='" + textBox1.Text + "',lname='" + textBox2.Text + "' WHERE Id='" + getandset.getId() + "' ";
            conn.manipulate(query);
            MessageBox.Show("Saved Sucessfully!!");
        }

        private void close_Click(object sender, EventArgs e)
        {

        }
        private void editUserDetails_Load(object sender, EventArgs e)
        {
            string query = "select fname,lname,username,id from users where Id = " + getandset.getId();
                DataTable dt = conn.retrieve(query);
                textBox1.Text = dt.Rows[0][0].ToString();
                textBox2.Text = dt.Rows[0][1].ToString();
                uname.Text = dt.Rows[0][2].ToString();
               
        }
    }
}
