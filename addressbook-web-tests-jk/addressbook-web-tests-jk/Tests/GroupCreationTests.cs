﻿using System;
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
            app.Navigator. HomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups. InitGroupCreation();
            GroupData group = (new GroupData("aaa"));
            group.Header = "ttt";
            group.Footer = "ggg";
            app.Groups. FillGroupForm(group);
            app.Groups. SubmitGroupCreation();
            app.Groups.ReturnToGroupsPage();
            app.Auth.Logout();
        }

        

        

        

        

        

        

        

   
        
    }
}
