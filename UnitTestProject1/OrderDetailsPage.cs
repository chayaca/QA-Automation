using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class OrderDetailsPage
    {
        IWebDriver driver;
        public OrderDetailsPage()
        {
            driver = Browser.GetDriver();
        }
        public void fill(PersonDetails person)
        {
            Thread.Sleep(5000);
            var shipment = new SelectElement(driver.FindElement(By.Id("shipment")));
            shipment.SelectByValue("2");
            driver.FindElement(By.Id("email")).SendKeys(person.email);
            driver.FindElement(By.Id("customerFirstName")).SendKeys(person.fName);
            driver.FindElement(By.Id("customerLastName")).SendKeys(person.lName);
            driver.FindElement(By.Id("phone")).SendKeys(person.phone);
            driver.FindElement(By.Id("isConfirm")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("form-submit-button")).Click();
           
        }

    }
}
