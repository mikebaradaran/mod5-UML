using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Steps
{
    public class LocationFinder
    {
        public static string getInterstingParts(string city, string location)
        {
            if (city == "London" && location == "south")
                return "Greenwich";

            else
                return "";

        }
    }
}
