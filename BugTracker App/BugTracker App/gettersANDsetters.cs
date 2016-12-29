using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    class gettersANDsetters
    {

        private static int id,bugid;
        private static int userId;
        private static string uname,filePath;

        public void setId(int kid)
        {
            id = kid;
        }
        public int getId()
        {
            return id;
        }
        public void setusertypeID(int uid)
        {
            userId = uid;
        }
        public int getusertypeID()
        {
            return userId;
        }
        public void setbugId(int bid)
        {
            bugid = bid;
        }
        public int getbugId()
        {
            return bugid;
        }
        public void setUname(string username)
        {
            uname = username;
        }
        public string getUname()
        {
            return uname;
        }

        public void setFilename(string filename)
        {
            filePath = filename;
        }
        public string getFilename()
        {
            return filePath;
        }
        

    }
}
