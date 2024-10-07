// See https://aka.ms/new-console-template for more information
using System;

namespace SonarCloudTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Example of an unused variable
            int unusedVariable = 42;

            // Example of a method that could be static
            Program program = new Program();
            program.NonStaticMethod();

            // Example of a magic number
            int result = program.Add(5, 10);
            Console.WriteLine("Result: " + result);

            // Example of a hardcoded string
            string hardcodedString = "This is a hardcoded string";

            // Example of an empty catch block
            try
            {
                int divisionResult = 10 / 0;
            }
            catch (Exception)
            {
                // Do nothing
            }

            // Example of a method with too many parameters
            program.MethodWithTooManyParameters(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            // Example of a potential null reference exception
            string potentiallyNullString = null;
            Console.WriteLine(potentiallyNullString.Length);

            // Example of an infinite loop
            while (true)
            {
                Console.WriteLine("This is an infinite loop.");
            }
        }

        void NonStaticMethod()
        {
            Console.WriteLine("This method could be static.");
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        void MethodWithTooManyParameters(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        {
            Console.WriteLine("This method has too many parameters.");
        }
    }
}