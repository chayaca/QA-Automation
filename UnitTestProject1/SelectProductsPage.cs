using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class SelectProductsPage
    {
        IWebDriver driver;
        public SelectProductsPage() {
            driver = Browser.GetDriver();
        }
        
        public void fill(long[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                driver.FindElement(By.CssSelector("[data-prodid='" + items[i] + "'] a.btn")).Click();
                if (i < items.Length - 1)
                {
                    Thread.Sleep(3000);
                    driver.FindElement(By.CssSelector("#add2basket-modal button")).Click();
                    Thread.Sleep(3000);
                }
                else
                {
                    driver.FindElement(By.CssSelector("#add2basket-modal a")).Click();
                    Thread.Sleep(2000);
                }
            }
        }

    }
}
