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
    public class ContactHelper : HelperBase
    {
        public ContactHelper (IWebDriver driver) : base(driver)
        {

        }
        public void GotoAddNew()
        {

            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void FillContact(ClassFillContact group)
        {

            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(group.Firstname);
            driver.FindElement(By.Name("middlename")).Click();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(group.Middlename);
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
        }

    }
}
