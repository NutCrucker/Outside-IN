using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutsideInDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupPoster poster = GroupPosterFactory.GetGroupPoster();
            RunDetails runDetails = UserInterrogator.GetRunDetails();
            poster.StartPosting(runDetails);
        }
    }
}
