using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace addressbook_web_tests_jk
{
    public class TestBase
    {


        //protected IWebDriver driver;
        //private StringBuilder verificationErrors;
        //protected string baseURL;
        //private bool acceptNextAlert = true;

        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            // driver = new FirefoxDriver();
            // baseURL = "http://localhost/addressbook/addressbook";
            // verificationErrors = new StringBuilder();

            // logInOutHelper = new LogInOutHelper(driver);
            //navigator = new NavigationHelper(driver, baseURL);
            // groupHelper = new GroupHelper(driver);
            // contactHelper = new ContactHelper(driver);
            app = new ApplicationManager();


        }

        [TearDown]
        public void TeardownTest()
        {

            app.Stop();
        }
       
        
        
       
      
     
        
       
        
    }
}
