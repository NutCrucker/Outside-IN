using System;

namespace OutsideInDevelopment
{
    internal class UserInterrogator
    {
        internal static RunDetails GetRunDetails()
        { 
            return new RunDetails(AskForGroups(), AskForPath(), AskForLoginDetails());
        }
        private static string AskForPath()
        {
            MessageManager.AskForPath();
            string path = Console.ReadLine();
            while (!Validator.IsValidPath(path))
            {
                MessageManager.InvalidPath();
                path = Console.ReadLine();
            }
            return path;
        }
        private static string[] AskForGroups()
        {
            MessageManager.AskForNumOfGroups();
            string[] groups = new string[Validator.getInteger(Console.ReadLine())];
            for(int i = 0; i < groups.Length; i++)
            {
                MessageManager.GetGroupName();
                groups[i] = Console.ReadLine();
            }
            return groups;
        }
        public static LoginDetails AskForLoginDetails()
        {
            LoginDetails loginDetails = new LoginDetails();
            MessageManager.InsertEmail();
            loginDetails.email = Console.ReadLine();
            MessageManager.InsertPassword();
            loginDetails.password = Console.ReadLine();
            return loginDetails;
        }

        internal static Browser GetBrowser()
        {
            MessageManager.BrowserChoice();
            int browserType = Validator.GetValidBrowserType(Console.ReadLine());
            switch (browserType)
            {
                case 1:
                    return Browser.Chrome;
                case 2:
                    return Browser.IE;
                case 3:
                    return Browser.Firefox;
                default:
                    throw new InvalidBrowserException();
            }

        }
    }
}