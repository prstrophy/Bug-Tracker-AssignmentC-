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
    public partial class UserRegistration : Form
    {
        DatabaseConnection conn = new DatabaseConnection();
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            query = "SELECT * FROM usertype ";
            DataTable dt = conn.retrieve(query);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "usertype";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query;
            int comId = Convert.ToInt16(this.comboBox1.SelectedValue);
            query = "INSERT into Users(fname,lname,username,password,usertypeid) VALUES ('" + fname.Text + "','" + lname.Text + "','" + uname.Text + "','" + pwd.Text + "'," + comId + ")";
            conn.manipulate(query);
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
         
        }

    }
}
