using System;
using System.IO;

namespace ResTest.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Outer: " + File.ReadAllText("res/outer.txt")); 
            Console.WriteLine("Inner: " + File.ReadAllText("res/inner.txt")); 
        }
    }
}
