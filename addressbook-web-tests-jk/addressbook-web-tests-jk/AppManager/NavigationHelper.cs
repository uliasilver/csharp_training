using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests_jk
{
   public class NavigationHelper : HelperBase
    {
       
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            
            this.baseURL = baseURL;
        }
        public void HomePage()
        {
            if (driver.Url == baseURL + "/addressbook/addressbook")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL+ "/addressbook/addressbook");
            
         
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).Click();
        }
        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
