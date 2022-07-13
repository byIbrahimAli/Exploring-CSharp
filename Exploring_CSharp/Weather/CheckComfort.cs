using System;
using WeatherUtilities = Pluralsight.MyUtilities.WeatherUtilities; // sets WeatherUtilities to point to namespace.class. Makes for easy reference in code

namespace Pluralsight.MyUtilities
{
    public class CheckComfort
    {
        static void Main(string[] args)
        {
            WeatherUtilities.Report("Bologna", 23, 65); // ~73 F
        }
    }
}

