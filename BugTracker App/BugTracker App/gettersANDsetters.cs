using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    class gettersANDsetters
    {

        private static int id;
        private static int userId;

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
        

    }
}
