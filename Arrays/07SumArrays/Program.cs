using System;
using System.Linq;

namespace _07SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int maxLenght = Math.Max(arr1.Length, arr2.Length);
            int[] sumArray = new int[maxLenght];

            for (int i = 0; i < maxLenght; i++)
            {
                sumArray[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
