using System;
/**
 * System is an important and most useful namespace in .NET
 * Contains cool stuff like Console
 */

namespace Pluralsight.GettingStarted.Basics // Note: actual namespace depends on the project name.
{
    internal class NamingConventionsAndBasicFunction
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}

        static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            float temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;
            // all decimals "1.8" are double's and not floats because
            // doubles are more precise. It's an 'unsafe conversion' from
            // a double to a float, hence the error.

            // to write a decimal as a float, add 'f' afterwards: "1.8f"
            return temperatureCelsius;
        }

        /**
         * method (function) names are uppercase camelback and don't typically 
         * have _ to seperate words -> ThisIsAFunctionNameExample
         * 
         * methods are called similar to java, class.methodname(arguments);
         * 
         * argument names use lowercase camelback and again don't use _ to 
         * seperate words -> thisIsAnArgument
         * 
         * code layout is different to java:
         *  void javaMethod() {
         *      System.out.println("yeee");
         *  }
         * in C# the there is no code on the same line as the curly braces:
         *  void CSharpMethod()
         *  {
         *      Console.WriteLine("yeee");
         *  }
         * 
         */

        /// <summary>This is a <i>formatted</i> comment. Used to generate
        /// documentation for classes and methods</summary>
    }
}