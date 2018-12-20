using System;

namespace _02SignOfIntegerNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = GetSign(n);
            Console.WriteLine($"The number {n} is {result}.");

        }

        static string GetSign(int n)
        {
            string result = "";

            if (n>0)
            {
                 result = "positive";
            }
            else if (n<0)
            {
                 result = "negative";
            }
            else if (n == 0)
            {
                result = "zero";
            }
            return result;
        }
    }
}
