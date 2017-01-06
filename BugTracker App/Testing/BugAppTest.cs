using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace Testing
{
    [TestClass]
    public class BugAppTest


    {
        [TestMethod]
        public void LoginTest()
        {
            string username = "admin";
            string password = "admin";

            string expectedResult = "Pass";
            string actualResult;
            BugTrackerApp.commonFunction obj = new BugTrackerApp.commonFunction();

            string query = "select * from administrator where username='" + username + "' and password='" + password + "'";

            actualResult = obj.display(query);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void LoginFailTest()
        {
            string username = "admin";
            string password = "asdasd";

            string expectedResult = "Pass";
            string actualResult;
            BugTrackerApp.commonFunction obj = new BugTrackerApp.commonFunction();

            string query = "select * from administrator where username='" + username + "' and password='" + password + "'";

            actualResult = obj.display(query);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void UserTest()
        {
          
                string username = "";
            BugTrackerApp.commonFunction bcf = new BugTrackerApp.commonFunction();
                DataTable actualResult = bcf.userChck(username);
                Assert.AreEqual(0, actualResult.Rows.Count);
            }
        [TestMethod]
        public void UserfailTest()
        {

            string username = "admin";
            BugTrackerApp.commonFunction bcf = new BugTrackerApp.commonFunction();
            DataTable actualResult = bcf.userChck(username);
            Assert.AreEqual(1, actualResult.Rows.Count);
        }

        [TestMethod]
        public void Registration()
        {
            string firstname = "prashid";
            string lastname = "pradhan";
            string username = "prstrophy1";
            string password = "awesome";
            string usertypeid = "1";

            BugTrackerApp.commonFunction bcf = new BugTrackerApp.commonFunction();

            var result = bcf.userreg(firstname, lastname, username, password, usertypeid);

            Assert.AreEqual(true, result);
        }

        [TestMethod]

        public void RegistartionFalseTesting()
        {
            string firstname = "";
            string lastname = "";
            string username = "";
            string password = "";
            string usertypeid = "";
            BugTrackerApp.commonFunction bcf = new BugTrackerApp.commonFunction();

            var result = bcf.userreg(firstname, lastname, username, password, usertypeid);

            Assert.IsInstanceOfType(result, typeof(System.Collections.Generic.List<string>));

        }

       

    }
    }
