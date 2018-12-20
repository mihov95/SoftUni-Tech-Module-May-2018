using System;
using System.Linq;

namespace _04TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool foundSum = TripleSum(numbers);

            if (!foundSum)
            {
                Console.WriteLine("No");
            }

        }

        private static bool TripleSum(int[] numbers)
        {
            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                        isFound = true;
                    }
                }
            }

            return isFound;
        }
    }
}
