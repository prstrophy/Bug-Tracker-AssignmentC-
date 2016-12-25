using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    class DBConnection
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Temp\database.mdf;Integrated Security = True; Connect Timeout = 30");



        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter reader = new SqlDataAdapter();
        DataTable dt = new DataTable();


        public void manipulate(string query)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable retrieve(string query)
        {
            DataSet ds = new DataSet();
            reader = new SqlDataAdapter(query, con);
            reader.Fill(ds);
            return ds.Tables[0];

        }
    }
}
