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
    public partial class SigninAdmin : Form
    {
        connection conn = new connection();
        gettersANDsetters getandset = new gettersANDsetters();
        int userid;
        public SigninAdmin()
        {
            InitializeComponent();
        }

        internal connection connection
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void sAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            String query = "SELECT * FROM administrator WHERE USERNAME = '" + textBox1.Text + "' AND PASSWORD = '" + textBox2.Text + "'";

            DataTable dt = conn.retrieve(query);
            if (dt.Rows.Count > 0)
            {
                //Int32 First = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());

                //open dashboard;
                foreach (DataRow row in dt.Rows)
                {
                    string id = row["id"].ToString();
                
                    userid = Convert.ToInt32(id);
                    
                    
                    getandset.setId(userid);


                }
               

                    this.Hide();
                    MessageBox.Show("Login Sucessfull");
                    adminDashboard dsd = new adminDashboard();

                    dsd.Closed += (s, args) => this.Close();
                    dsd.Show();

               


            }

            else
            {
                MessageBox.Show("Username OR Password Mismatch::");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    internal class AdminDashboard
    {
        public Func<object, object, object> Closed { get; internal set; }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
