using System;
using System.Linq;

namespace _09ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int lenght = numbers.Length;
            int[] result = new int[lenght];

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }
            else if (numbers.Length % 2 != 0)
            {
                result = new int[3];
                result[0] = numbers[lenght / 2 - 1];
                result[1] = numbers[lenght / 2];
                result[2] = numbers[lenght / 2 + 1];
            }
            else if (lenght % 2 == 0)
            {
                result = new int[2];
                result[0] = numbers[lenght / 2 - 1];
                result[1] = numbers[lenght / 2 ];
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
