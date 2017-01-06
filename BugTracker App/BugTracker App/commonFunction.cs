using BugTrackerApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    public class commonFunction
    {
        connection conn = new connection();
        public string display(string query)
        {
            DataTable dt = conn.retrieve(query);
            if (dt.Rows.Count > 0)
                return "Pass";
            else
                return "Fail";
        }

        public DataTable userChck(string username)
        {
            string sql = "select * from users where username = '" + username + "'";
            connection conn = new connection();
            return conn.retrieve(sql);
        }

        public object userreg(string firstname, string lastname, string username, string password, string usertypeid)
        {
            List<string> error = new List<string>();

            if (String.IsNullOrEmpty(firstname))
            {
                error.Add("First name is required");
            }
            else if (!Regex.IsMatch(firstname, @"^[a-zA-Z]+$"))
            {
                error.Add("only aplhabets are allowed");
            }

            if (String.IsNullOrEmpty(lastname))
            {
                error.Add("lastname is required");
            }
            else if (!Regex.IsMatch(lastname, @"^[a-zA-Z]+$"))
            {
                error.Add("only aplhabets are allowed");
            }

            if (String.IsNullOrEmpty(username))
            {
                error.Add("Username is required");
            }
            else if (userChck(username).Rows.Count != 0)
            {
                error.Add("Username taken");
            }

            if (String.IsNullOrEmpty(password))
            {
                error.Add("password is required");
            }
           
            if (error.Count == 0)
            {

                try
                {
                    string query = "INSERT INTO users (Username,Password,fname,lname,usertypeid) VALUES('" + username + "', '" + password + "','" + firstname + "','" + lastname + "','" + usertypeid + "')";
                    connection con = new connection();
                    con.manipulate(query);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else
            {
                return error;
            }
        }

    
    }

}



