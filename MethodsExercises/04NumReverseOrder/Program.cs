using System;

namespace _04NumReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReverseNumber(number);
            
        }
            
        static void ReverseNumber(string number)
        {
            string result = "";
            char symbol = '\0';

            for (int i = number.Length - 1; i >= 0; i--)
            {
                symbol = number[i];
                result += symbol;
            }

            Console.WriteLine(result);
        }
    }
}
