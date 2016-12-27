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
    public partial class Signin : Form
    {

        DBConnection conn = new DBConnection();
        gettersANDsetters getandset = new gettersANDsetters();
        int usertype,userid;

         public Signin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            Signin sn = new Signin();
            
            String query = "SELECT * FROM users WHERE USERNAME = '" + uname.Text + "' AND PASSWORD = '" + pwd.Text + "'";
            
            DataTable dt = conn.retrieve(query);
            if (dt.Rows.Count > 0)
            {
                //Int32 First = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());

                //open dashboard;
                foreach (DataRow row in dt.Rows)
                {
                    string id = row["id"].ToString();
                    string fname = row["fname"].ToString();
                    string usertypeId = row["usertypeid"].ToString();
                    userid = Convert.ToInt32(id);
                    usertype = Convert.ToInt32(usertypeId);
                    getandset.setusertypeID(usertype);
                    getandset.setId(userid);


                }
                if (usertype == 1)
                {

                    this.Hide();
                    MessageBox.Show("Login Sucessfull");
                    DeveloperDashboard ds = new DeveloperDashboard();
                    
                    ds.Closed += (s, args) => this.Close();
                    ds.Show();
                    
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Login Sucessfull");                
                    TesterDashboard dst = new TesterDashboard();
                    dst.Closed += (s, args) => this.Close();
                    dst.Show();
                }
                
                
             }

            else
            {
                MessageBox.Show("Username OR Password Mismatch::");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {

           this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
   

        }
    }
}
