using System;

namespace _11OddNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num != (num%2= 0))
            {
                Console.WriteLine(num);
            }
        }
    }
}
