using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    class Browser
    {
        private static IWebDriver driver = new ChromeDriver();

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void Close()
        {
            driver.Close();
            driver = null;
        }
    }

}
