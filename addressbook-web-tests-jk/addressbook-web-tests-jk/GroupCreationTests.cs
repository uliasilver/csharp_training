using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace addressbook_web_tests_jk

{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        
        

        [Test]
        public void CroupCreationTests()
        {
            HomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = (new GroupData("aaa"));
            group.Header = "ttt";
            group.Footer = "ggg";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            Logout();
        }

        

        

        

        

        

        

        

   
        
    }
}
