using System;

namespace _09MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int count = 1;

            while (count <= 10)
            {
                
                Console.WriteLine($"{input} X {count} = {input * count}");
                count++;
            }
        
        }
    }
}
