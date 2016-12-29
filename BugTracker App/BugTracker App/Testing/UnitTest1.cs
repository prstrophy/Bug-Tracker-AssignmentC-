using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string username = "admin1";
            string password = "admin12";
     
            string expectedResult = "Pass";
            string actualResult;
            BugTrackerApp.commonFunction obj = new BugTrackerApp.commonFunction();
          
            string query = "select * from dbo.administrator where uname='" + username + "' and pwd='" + password + "'";

            actualResult = obj.display(query);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
