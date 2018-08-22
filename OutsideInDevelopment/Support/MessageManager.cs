using System;

namespace OutsideInDevelopment
{
    internal static class MessageManager
    {
        
        internal static void EndOfGroupPostingMessage()
        {
            Console.WriteLine("Finished posting in the requested groups, what would you like to do next?");
        }

        internal static void SuccessfulLogin()
        {
            Console.WriteLine("Logged in successfully!");
        }

        internal static void AskForPath()
        {
            Console.WriteLine("Please enter the path of the file you would like to post:");
        }

        internal static void UnsuccessfulLogin()
        {
            Console.WriteLine("Invalid login details, closing the application - please try again.");
        }

        internal static void AskForNumOfGroups()
        {
            Console.WriteLine("In how many groups would you like to post?");
        }

        internal static void InvalidPath()
        {
            Console.WriteLine("Invalid path! please enter a correct path");
        }

        internal static void GetGroupName()
        {
            Console.WriteLine("Please enter a name of the group you would like to post in:");
        }

        internal static void InsertEmail()
        {
            Console.WriteLine("Please insert Email:");
        }

        internal static void InsertPassword()
        {
            Console.WriteLine("Please insert Password");
        }

        internal static void BrowserChoice()
        {
            Console.WriteLine("What browser would you like to use?");
            Console.WriteLine("1 - Chrome");
            Console.WriteLine("2 - IE");
            Console.WriteLine("3 - Firefox");
        }

        internal static void NotCorrectGroup()
        {
            Console.WriteLine("Not the correct group, moving on.");
        }
    }
}