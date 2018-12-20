using System;
using System.Collections.Generic;

namespace _01Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type how many numbers you want to add: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number to add: ");
                var a = int.Parse(Console.ReadLine());

                sum += a;
            }

            Console.WriteLine($"Sum => {sum}");


        }
    }
}
