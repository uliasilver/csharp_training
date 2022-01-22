using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests_jk
{
    public class ContactHelper : HelperBase
    {
        ApplicationManager _manager;
        public ContactHelper (ApplicationManager manager) : base(manager)
        {
            _manager = manager;
        }

        

        public ContactHelper CreateContact()
        {
            GotoAddNew();
            FillContact(new ClassFillContact("test", "testov"));
            return this; ;
        }

        public ContactHelper GotoAddNew()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactHelper FillContact(ClassFillContact group)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(group.Firstname);
            driver.FindElement(By.Name("middlename")).Click();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(group.Middlename);
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }


        public ContactHelper SelectContact(int index)
        {
            var checkboxes = driver.FindElements(By.Name("selected[]"));
            if (checkboxes.Count == 0)
                throw new Exception("Нет элементов для выбора");
            checkboxes[index].Click();
            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(true), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }

        public ContactHelper UpdateContact(ClassFillContact group)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(group.Firstname);
            driver.FindElement(By.Name("middlename")).Click();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(group.Middlename);
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public void EditContact(int index)
        {
            var editLinks = driver.FindElements(By.XPath("//img[@alt='Edit']"));
            if (editLinks.Count == 0)
                throw new Exception("Нет контактов для редактирования");
            editLinks[index].Click();
        }

        private string CloseAlertAndGetItsText(bool acceptNextAlert)
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
