using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace OutsideInDevelopment
{
    internal class FacebookUtil
    {
        IWebDriver webDriver;
        LoginPageObject loginPage = new LoginPageObject();
        MainPageObject mainPage = new MainPageObject();
        GroupsPageObject groupPage = new GroupsPageObject();
        public FacebookUtil(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, loginPage);
            PageFactory.InitElements(webDriver, mainPage);
            PageFactory.InitElements(webDriver, groupPage);
        }

        internal void SearchGroup(string name)
        {
            mainPage.Search(name);
        }
        internal bool GoToGroup(string name)
        {
            IWebElement Group = webDriver.FindElement(By.PartialLinkText(name));
            Group.Click();
            System.Threading.Thread.Sleep(2000);
            return Validator.ValidateGroup(webDriver, groupPage, name);
        }
        internal void PostInGroup(string path)
        {
            groupPage.Post(path);   
        }
        internal void LoginToFacebook(LoginDetails loginDetails)
        {
            try
            {
                loginPage.Login(loginDetails.email, loginDetails.password);
                Validator.ValidateLogin(webDriver);
                MessageManager.SuccessfulLogin();
                IgnoreNotifications();
            }
            catch(InvalidLoginException)
            {
                MessageManager.UnsuccessfulLogin();
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        internal void ReturnToMainPage()
        {
            mainPage.ReturnToMainPage();
        }

        private void IgnoreNotifications()
        {
            System.Threading.Thread.Sleep(5000);
            Actions builder = new Actions(webDriver);
            builder.MoveToElement(webDriver.FindElement(By.Id("blueBarDOMInspector")), 10, 25).Click().Build().Perform();
        }
    }
}