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
        private IWebDriver driver;
        private string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL) : base(driver)
        {
            
            this.baseURL = baseURL;
        }
        public void HomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).Click();
        }
        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
