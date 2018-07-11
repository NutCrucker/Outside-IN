using System;

namespace OutsideInDevelopment
{
    internal class GroupPosterFactory
    {
        internal static GroupPoster GetGroupPoster()
        {
            return new GroupPoster(UserInterrogator.GetBrowser());
        }
    }
}