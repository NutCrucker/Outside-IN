using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace OutsideInDevelopment
{
    internal class LoginPageObject
    {
        [FindsBy(How = How.Id, Using = "pass")]
        private IWebElement Password { get; set; }
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Email { get; set; }

        internal void Login(string email, string password)
        {
            InsertEmail(email);
            InsertPassword(password);
            Password.SendKeys(Keys.Enter);
        }
        private void InsertPassword(string password)
        {
            Password.SendKeys(password);
        }

        private void InsertEmail(string email)
        {
            Email.SendKeys(email);
        }
    }
}