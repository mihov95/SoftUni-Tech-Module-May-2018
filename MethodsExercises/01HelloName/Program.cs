using System;

namespace _01HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Name(name);
        }
    
        static string Name(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return name;
        }
    }
}
