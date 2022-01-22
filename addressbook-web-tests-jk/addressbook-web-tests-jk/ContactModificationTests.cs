using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests_jk
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            app.Contact.EditContact(0);
            app.Contact.UpdateContact(new ClassFillContact("ololo", "пыщ пыщ"));

        }
    }
}
