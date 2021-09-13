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
    class PaymentPage
    {

        IWebDriver driver;
        public PaymentPage() 
        {
            driver = Browser.GetDriver();
        }
        public void fill(CreditCard card)
        {
            Thread.Sleep(5000);
            driver.FindElement(By.Id("Track2CardNo")).SendKeys(card.CardNum.ToString());

            var selectMonth = new SelectElement(driver.FindElement(By.Id("expMonth")));
            selectMonth.SelectByValue(card.ValidityMonth);

            var selectYear = new SelectElement(driver.FindElement(By.Id("expYear")));
            selectYear.SelectByValue(card.ValidityYear);
            driver.FindElement(By.Id("cvv")).SendKeys(card.Cvv);
            driver.FindElement(By.Id("personalId")).SendKeys(card.Id.ToString());

           
        }
    }
}
