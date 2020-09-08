using System;

namespace HelloWorldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Alex!");
            System.Console.WriteLine("What is your name?");
            var input = Console.ReadLine();
            System.Console.WriteLine($"Hello {input}");
            System.Console.WriteLine("Hello {0}", input);
        }
    }
}
