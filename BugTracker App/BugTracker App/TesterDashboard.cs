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
    public partial class TesterDashboard : Form
    {
        connection conn = new connection();
        gettersANDsetters getandset = new gettersANDsetters();
        int BUGID;
        public TesterDashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value.ToString() == "Update")
            {
                BUGID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BugId"].Value);
                string query = "select lineNum,method,class,description,sourcefile from bug where bugId = " + BUGID;
                DataTable dt = conn.retrieve(query);
                linenumber.Text = dt.Rows[0][0].ToString();
                methodname.Text = dt.Rows[0][1].ToString();
                classname.Text = dt.Rows[0][2].ToString();
                richTextBox1.Text = dt.Rows[0][3].ToString();
                sourcefile.Text = dt.Rows[0][4].ToString();
                Save.Text = "Update";
            }
        }

        private void dashboardForTester_Load(object sender, EventArgs e)
        {
            DisplayBug();
            
            label7.Text = "Welcome,"+getandset.getUname();
        }
        public void DisplayBug()
        {
            int USERID= getandset.getId();
            string query = "SELECT * FROM bug WHERE testerId="+USERID+" ";
            
            DataTable dt = conn.retrieve(query);
            dataGridView1.DataSource = dt;
        }

        private void linenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void methodname_TextChanged(object sender, EventArgs e)
        {

        }

        private void classname_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (linenumber.Text == "" || sourcefile.Text == "" || methodname.Text == "" || classname.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("None Of the field can be Empty!!");
            }
            else
            {
                double num;

                if (double.TryParse(linenumber.Text, out num))
                {
                    if (Save.Text == "Save")
                    {
                        string query;
                        string bugStatus = "Unfixed";
                        int LineNum = Convert.ToInt32(linenumber.Text);
                        query = "insert into bug (testerId, method, class, description, fixStatus, bugReportedDate, lineNum,sourceFile) values('" + getandset.getId() + "','" + methodname.Text + "','" + classname.Text + "','" + richTextBox1.Text + "','" + bugStatus + "','" + DateTime.Now + "', " + LineNum + ",'" + sourcefile.Text + "' )";
                        conn.manipulate(query);
                        DisplayBug();
                    }
                    else if (Save.Text == "Update")
                    {
                        string query;
                        int LineNum = Convert.ToInt32(linenumber.Text);

                        query = "UPDATE bug SET lineNum='" + LineNum + "',method='" + methodname.Text + "',sourceFile='" + sourcefile.Text + "',class='" + classname.Text + "',description='" + richTextBox1.Text + "' WHERE bugId='" + BUGID + "' ";
                        conn.manipulate(query);
                        DisplayBug();
                    }
                }
                else
                {
                    MessageBox.Show("Line no must be numeric");
                }

            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeveloperDashboard errorfixwindow = new DeveloperDashboard();
            errorfixwindow.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdetails eud = new Userdetails();
            eud.Show();
        }

        private void checkFixedBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fixedHistoryDeveloper fhd = new fixedHistoryDeveloper();
            fhd.Show();
        }

        private void sourcefile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
