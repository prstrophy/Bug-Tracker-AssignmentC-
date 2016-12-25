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
    public partial class RegistrationForm : Form
    {
        DBConnection conn = new DBConnection();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signUp_Click(object sender, EventArgs e)
        {
            string query;
            int comId = Convert.ToInt16(comboBox1.SelectedValue);
            query = "insert into users(fname,lname,username,password,usertypeid) values('" + fname.Text + "','" + lname.Text + "','" + uname.Text + "','" + pwd.Text + "'," + comId + ")";
            conn.manipulate(query);
            MessageBox.Show("Registration Sucessfull Please log in to continue!!");
            this.Close();
            Signin sn = new Signin();
            sn.Show();

            
        }
        private void comboBoxSetting()
        {
            string query;
            query = "SELECT * FROM userType ";
            DataTable dt = conn.retrieve(query);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "userTypeId";
            comboBox1.DisplayMember = "userType";
        }

        private void registrationForm_Load(object sender, EventArgs e)
        {
            comboBoxSetting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin registration = new Signin();
            registration.Show();
        }
    }
}
