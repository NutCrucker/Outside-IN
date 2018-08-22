using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OutsideInDevelopment.Configs;

namespace OutsideInDevelopment
{
    internal class Validator
    {
        internal static int GetValidBrowserType(string value)
        {
            int[] validBrowserValue = { 1, 2, 3 };
            int browserType = 0;
            while (!Int32.TryParse(value, out browserType)||(!validBrowserValue.Contains(browserType)))
            {
                Console.WriteLine("Invalid Value, Please enter again:");
                value = Console.ReadLine();
            }
            return browserType;
        }
                
        internal static bool IsValidPath(string path)
        {
            if (FileChecker.IsReadableFile(path))
                return true;
            else return false;
        }

        internal static int getInteger(string value)
        {
            int num;
            while (!Int32.TryParse(value, out num))
            {
                Console.WriteLine("Invalid value! Please enter a number:");
                value = Console.ReadLine();
            }
            return num;
        }

        internal static bool ValidateGroup(IWebDriver webDriver,GroupsPageObject groupsPage, string groupName)
        {
            string isGroup = @"group";
            string URL = webDriver.Url;
            Match match = Regex.Match(URL, isGroup);
            if (match.Success)
            {
                string PageString = groupsPage.GetGroupName();
                match = Regex.Match(PageString, groupName);
                if (match.Success) return true;
            }
            MessageManager.NotCorrectGroup();
            return false;
        }

        internal static void ValidateLogin(IWebDriver webDriver)
        {
            if((webDriver.Title != Titles.Default.FbEngTitle)&&(webDriver.Title != Titles.Default.FbHebTitle))
            {
                try
                {
                    IWebElement webElement = webDriver.FindElement(By.Name("q"));
                }
                catch
                {
                    throw new InvalidLoginException();
                }
            }
        }
    }
}