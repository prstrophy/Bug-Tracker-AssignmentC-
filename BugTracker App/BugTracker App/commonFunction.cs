using BugTrackerApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    public class commonFunction
    {
        DBConnection conn = new DBConnection();
        public string display(string query)
        {
            DataTable dt = conn.retrieve(query);
            if (dt.Rows.Count > 0)
                return "Pass";
            else
                return "Fail";
        }
    }
}
