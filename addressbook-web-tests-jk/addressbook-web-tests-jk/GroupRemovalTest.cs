using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace addressbook_web_tests_jk
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
      

        [Test]
        public void GroupRemovalTest()
        {
            HomePage();
            Login(new AccountData ("admin", "secret"));
            GoToGroupsPage();
            SelectGroup(1);
            RemoveGroup();
            ReturnToGroupsPage();
        }

        

        

        

        

        

        

       

        

       
    }
}
