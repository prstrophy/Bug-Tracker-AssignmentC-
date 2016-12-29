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
    public partial class userType : Form
    {
        connection conn = new connection();
        int utypeId;
        public userType()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value.ToString() == "Update")
            {
                 utypeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                string query = "select userTypeId,userType from userType where userTypeId = " + utypeId;
                DataTable dt = conn.retrieve(query);
                textBox1.Text = dt.Rows[0][1].ToString();
           
                save.Text = "Update";
            }
            displayuType();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (save.Text == "Add")
            {
                string quer = "insert into userType(userType) values('" + textBox1.Text + "')";
                conn.manipulate(quer);
                MessageBox.Show("User type added sucessfully!!");
            }
            else if (save.Text == "Update")
            {
                string query;
                query = "UPDATE userType SET userType='" + textBox1.Text + "' WHERE userTypeId='" + utypeId + "' ";
                conn.manipulate(query);
                MessageBox.Show("User type Updated sucessfully!!");
            }
            displayuType();
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void displayuType()
        {
            string query = "select * from userType ";
            DataTable dt = conn.retrieve(query);
            dataGridView1.DataSource = dt;
        }

        private void userType_Load(object sender, EventArgs e)
        {
            displayuType();
        }
    }
}
