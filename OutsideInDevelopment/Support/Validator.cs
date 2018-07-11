using System;
using System.IO;
using System.Linq;
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

        internal static bool ValidateGroup()
        {
            Console.WriteLine("Is this the correct group?[Y/N]");
            if (Console.ReadLine() == "Y") return true;
            else
            {
                Console.WriteLine("Not the correct group, moving on.");
                return false;
            }
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