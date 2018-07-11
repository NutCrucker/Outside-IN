using System;
using OpenQA.Selenium;
using OutsideInDevelopment.Configs;

namespace OutsideInDevelopment
{
    internal class BrowserUtil
    {
        public BrowserUtil()
        {
        }
        internal void StartFacebook(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(URLs.Default.Facebook);
        }
    }
}