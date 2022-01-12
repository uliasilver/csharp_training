using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests_jk
{
    [TestFixture]
    public class NewContact : TestBase
    {
        
        [Test]
        public void NewContactTest()
        {
            
            app.Contact.GotoAddNew();
            app.Contact.FillContact( new ClassFillContact ("test", "testov"));
            app.Auth.Logout();
        }

       

        

       

        

       

        

        

       

        
        
    }
}
