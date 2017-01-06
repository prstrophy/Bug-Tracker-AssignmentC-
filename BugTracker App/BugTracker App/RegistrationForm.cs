using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace BugTrackerApp
{
    public partial class registrationForm : Form
    {
        connection conn = new connection();
        gettersANDsetters getandsets = new gettersANDsetters();
        private string sourcePath;
        private string destinationPath;
        public registrationForm()
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
            if (!string.IsNullOrWhiteSpace(sourcePath) && File.Exists(sourcePath))
            {
                
                destinationPath += Path.GetFileName(sourcePath);
                if (File.Exists(destinationPath))
                    File.Delete(destinationPath);

                File.Copy(sourcePath, destinationPath);
            }
            
            if(fname.Text=="" || lname.Text=="" || uname.Text=="" || pwd.Text=="" ){
                MessageBox.Show("None Of the field can be Empty!!");
            }
            else{
                            String queri = "SELECT username FROM users WHERE username = '" + uname.Text + "'";

                            DataTable dt = conn.retrieve(queri);
                           

                             if (dt.Rows.Count > 0)
                        {
                            int compare = dt.Rows.Count;
                            string myString = compare.ToString();
                            Regex regex = new Regex("^[1-9]*$");
                            if (regex.IsMatch(myString))
                            {

                                pictureBox1.Image = Properties.Resources.invalid;

                                regexlbl.Text = "Username Already Exists!!.Try Another!!";
                            }
                            else
                            {

                                pictureBox1.Image = Properties.Resources.valid;

                                regexlbl.Text = "Valid";
                            }
                        }
                        else
                             {
                                 if (!string.IsNullOrWhiteSpace(sourcePath) && File.Exists(sourcePath))
                                 {

                                     
                                     if (File.Exists(destinationPath))
                                         File.Delete(destinationPath);
                                     File.Copy(sourcePath, destinationPath);
                                 }
                            string query;
                            int comId = Convert.ToInt16(comboBox1.SelectedValue);
                            query = "insert into users(fname,lname,username,password,usertypeid,image) values('" + fname.Text + "','" + lname.Text + "','" + uname.Text + "','" + pwd.Text + "'," + comId + ",'" + getandsets.getFilename() + "')";
                            conn.manipulate(query);
                            MessageBox.Show("Registration Sucessfull Please log in to continue!!");
                            this.Close();
                            Signin sn = new Signin();
                            sn.Show();
                        }
            }
           
            
            

            
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
       
        

    }
}
