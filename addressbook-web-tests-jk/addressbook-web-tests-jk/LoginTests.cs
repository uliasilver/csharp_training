﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests_jk
{
    [TestFixture]
    public  class LoginTests :TestBase
    {
        [Test]
        
        public void LoginWithValidCredentials()
        {
            //prepare
            app.Auth.LogOut();
            //action
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);
            //verification
            Assert.IsTrue(app.Auth.IsLoggedIn());
        }

        public void LoginWithInValidCredentials()
        {
            //prepare
            app.Auth.LogOut();
            //action
            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);
            //verification
            Assert.IsFalse(app.Auth.IsLoggedIn());
        }
    }
}
