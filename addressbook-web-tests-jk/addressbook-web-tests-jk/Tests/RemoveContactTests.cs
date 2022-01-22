using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;


namespace addressbook_web_tests_jk
{
    [TestFixture]
    public class RemoveContactTests : TestBase
    {

        [Test]
        public void RemoveContactTest()
        {

            app.Contact.SelectContact(0);
            app.Contact.RemoveContact();



        }
    }
}