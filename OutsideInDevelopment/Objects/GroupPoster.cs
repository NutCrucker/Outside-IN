using OpenQA.Selenium;
using System;

namespace OutsideInDevelopment
{
    internal class GroupPoster
    {
        BrowserUtil browserUtil = new BrowserUtil();
        FacebookUtil facebookUtil;
        private IWebDriver webDriver;
        public GroupPoster(Browser browser)
        {
            this.webDriver = DriverLoader.GetDriver(browser);
            this.facebookUtil = new FacebookUtil(webDriver);
        }

        internal void StartPosting(RunDetails runDetails)
        {
            browserUtil.StartFacebook(webDriver);
            facebookUtil.LoginToFacebook(runDetails.loginDetails);
            for (int i = 0; i < runDetails.GroupsToPost.Length; i++)
            {
                facebookUtil.SearchGroup(runDetails.GroupsToPost[i]);
                if (facebookUtil.GoToGroup(runDetails.GroupsToPost[i]))
                {
                    facebookUtil.PostInGroup(runDetails.path);
                }
            }
            facebookUtil.ReturnToMainPage();
            MessageManager.EndOfGroupPostingMessage();
        }
    }
}
