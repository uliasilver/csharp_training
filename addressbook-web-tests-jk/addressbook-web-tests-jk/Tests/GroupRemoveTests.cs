using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace addressbook_web_tests_jk
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
      

        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(1);


        }

        

        

        

        

        

        

       

        

       
    }
}
