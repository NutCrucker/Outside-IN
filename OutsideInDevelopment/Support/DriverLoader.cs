using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideInDevelopment
{
    public enum Browser
    {
        Chrome,
        IE,
        Firefox
    }
    public class DriverLoader
    {
        public static IWebDriver GetDriver(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    return new ChromeDriver();
                case Browser.IE:
                    return new InternetExplorerDriver();
                case Browser.Firefox:
                    return new FirefoxDriver();
                default:
                    throw new InvalidBrowserException();
            }
        }
    }
}
