using System;

Console.WriteLine("Hello, World!");

/**
 * Using C#9+ you can use 'top-level statements' which means
 * you can remove all the boilerplate. So the following:
 * 
 * using System;
 * namespace Exploring_CSharp
 * {
 *  public class TopLevelStatements
 *  {
 *      static void Main(string[] args)
 *      {
 *          Console.WriteLine("Hello, World!");
 *      }
 *  }
 * }
 * 
 * becomes what's in this .cs file :)
 * 
 * HOWEVER, remember, under the hood the more verbose code is being ran. 
 * The same logic behind namespaces, classes, main method. Top-level statements is just 'syntactic sugar', a nicer syntax.
 * It does not change the essence of the code!
 */