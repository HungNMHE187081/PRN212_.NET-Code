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
        }

        void NonStaticMethod()
        {
            Console.WriteLine("This method could be static.");
        }

        int Add(int a, int b)
        {
            return a + b;
        }
    }
}