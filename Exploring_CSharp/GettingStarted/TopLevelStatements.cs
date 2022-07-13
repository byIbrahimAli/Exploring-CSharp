using System;

namespace Pluralsight.GettingStarted.TopLevelStatements
{
    public class TopLevelStatements
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //}
    }
}

/**
 * Using C#9+ you can use 'top-level statements' which means
 * you can remove all the boilerplate to produce the following:
 * 
 * using System;
 * Console.WriteLine("Hello, World!");
 * 
 * HOWEVER, remember, under the hood the more verbose code is being ran. 
 * The same logic behind namespaces, classes, main method. Top-level statements is just 'syntactic sugar', a nicer syntax.
 * It does not change the essence of the code!
 */