using System;
using WeatherUtilities = Pluralsight.MyUtilities.WeatherUtilities; // sets WeatherUtilities to point to namespace.class. Makes for easy reference in code

namespace Pluralsight.MyUtilities
{
    public class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where should we go in May?");
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(77), 55);
            WeatherUtilities.Report("Bologna", 23, 65); // ~73 F
        }
    }
}

