using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = Browser.GetDriver();

            //ניתוב לאתר צומת ספרים
            driver.Navigate().GoToUrl("https://www.booknet.co.il");
          
            //כל הקטגוריות

            driver.FindElement(By.ClassName("menu")).Click();
            Thread.Sleep(2000);
            // למבצעים
            
            driver.FindElement(By.CssSelector("li[data-id='250']")).Click();
            Thread.Sleep(2000);
            //מבצע משחקים
            driver.FindElement(By.CssSelector("#sub-categories-container > div:nth-child(2) > div > div:nth-child(1) > a")).Click();
            Thread.Sleep(2000);
            //הוספה לסל
            long[] items = new long[] { 168001, 168003 };
            SelectProductsPage selectProductsPage = new SelectProductsPage();
            selectProductsPage.fill(items);
            Thread.Sleep(3000);
            //סל הקניות לתשלום-סיום קניה
            driver.FindElement(By.CssSelector(".categoryitems a > img")).Click();
            Thread.Sleep(2000);
            //מילוי פרטי הזמנה ותשלום באשראי עשיתי אחרי בחירת כל הספרים 
            //כיוון שאין מעבר לדף הבית אחרי התשלום
            //חיפוש ספר מעשה בחמישה בלונים
            driver.FindElement(By.Id("top-search")).SendKeys("מעשה בחמישה בלונים");
            driver.FindElement(By.Id("top-search-image-icon")).Click();

            // הוספה לסל
            selectProductsPage.fill(new long[] { 8118 });
            Thread.Sleep(3000);

            //מעבר לפרטי הזמנה
            driver.FindElement(By.CssSelector(".categoryitems a > img")).Click();

            //פרטי הזמנה
            PersonDetails person = new PersonDetails("Dvir", "Cohen", "DD@KK.LL", "0524785632");
            new OrderDetailsPage().fill(person);

            //כרטיס אשראי
            CreditCard card = new CreditCard(4580123412341234, "04", "27", "002", 111111118);
            new PaymentPage().fill(card);

            driver.Close();

        }
    }
}
