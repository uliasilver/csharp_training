using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace addressbook_web_tests_jk

{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        
        

        [Test]
        public void CroupCreationTests()
        {
            
            
            GroupData group = (new GroupData("aaa"));
            group.Header = "ttt";
            group.Footer = "ggg";
            
            app.Groups.Create(group);
              
            app.Auth.LogOut();
        }


        public void EmptyCroupCreationTests()
        {

            
            GroupData group = (new GroupData(""));
            group.Header = "";
            group.Footer = "";
            
            app.Groups.Create(group);
               
            app.Auth.LogOut();
        }














    }
}
