using System;

namespace _10CountIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    int number = int.Parse(input);
                    count++;
                }
                catch (FormatException)
                {
                    Console.WriteLine(count);
                    break;
                }
            }
        }
    }
}
