using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OutsideInDevelopment
{
    internal class MainPageObject
    {
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement SearchBar { get; set; }
        [FindsBy(How = How.Id, Using = "u_0_c")]
        private IWebElement MainPageButton { get; set; }

        public void ReturnToMainPage()
        {
            MainPageButton.Click();
        }
        public void Search(string value)
        {
            SearchBar.SendKeys(value);
            SearchBar.SendKeys(Keys.Enter);
        }
    }
}