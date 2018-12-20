using System;
using System.Linq;

namespace _02RotateSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sumArray = new int[arr.Length];

            for (int i = 0; i < rotations; i++)
            {
                Shift(arr);
                Sum(arr, sumArray);
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }

        private static void Sum(int[] arr, int[] sumArray)
        {
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] += arr[i];
            }
        }

        private static void Shift(int[] arr)
        {
            int last = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = last;

        }
    }
}
