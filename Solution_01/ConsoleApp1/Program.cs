using System;

namespace HelloWorldApp
{
    public class MyClass
    {
       public void Display<T,U> (T msg, U value)
        {
            Console.WriteLine($"{msg} : {value}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Display<string, int> ("Hello", 10);

            obj.Display<double , char> (103.5f, 'A');
            Console.ReadLine();
        }
    }
    
}