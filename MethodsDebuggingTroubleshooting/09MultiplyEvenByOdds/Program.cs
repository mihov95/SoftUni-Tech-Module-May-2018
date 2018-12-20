using System;

namespace _09MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            GetSumOfEven(number);
            GetSumOfOdds(number);
            int sumEvenAndOdds = GetSumOfEvenAndOdds(number);

            Console.WriteLine(sumEvenAndOdds);
        }

        static int GetSumOfEven(int number)
        {
            int sumEven = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    sumEven += lastDigit;
                }
                number /= 10;
            }

            return sumEven;
        }

        static int GetSumOfOdds(int number)
        {
            int sumOdds = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                {
                    sumOdds += lastDigit;
                }
                number /= 10;
            }

            return sumOdds;
        }

        static int GetSumOfEvenAndOdds(int number)
        {
            int sumEven = GetSumOfEven(number);
            int sumOdds = GetSumOfOdds(number);
            int sumEvenAndOdds = sumEven * sumOdds;
            return sumEvenAndOdds;
        }
    }
}
