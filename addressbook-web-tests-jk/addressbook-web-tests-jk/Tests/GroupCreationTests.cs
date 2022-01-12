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
            
            
            GroupData group = (new GroupData("aaa"));
            group.Header = "ttt";
            group.Footer = "ggg";
            app.Navigator.GoToGroupsPage();
            app.Groups
                .InitGroupCreation()
                .FillGroupForm(group)
                .SubmitGroupCreation()
                .ReturnToGroupsPage();
            app.Auth.Logout();
        }


        public void EmptyCroupCreationTests()
        {

            
            GroupData group = (new GroupData(""));
            group.Header = "";
            group.Footer = "";
            app.Navigator.GoToGroupsPage();
            app.Groups
                .InitGroupCreation()
                .FillGroupForm(group)
                .SubmitGroupCreation()
                .ReturnToGroupsPage();
            app.Auth.Logout();
        }














    }
}
