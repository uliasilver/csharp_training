﻿using System;
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
            app.Navigator.HomePage();
            app.Auth.Login(new AccountData ("admin", "secret"));
            app.Navigator. GoToGroupsPage();
            app.Groups SelectGroup(1);
            app.Groups RemoveGroup();
            app.Groups. ReturnToGroupsPage();
        }

        

        

        

        

        

        

       

        

       
    }
}
