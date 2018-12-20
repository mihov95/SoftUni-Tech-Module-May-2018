using System;
using System.Linq;

namespace _03FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = arr.Length / 4;
            int[] upperArr = new int[2 * k];
            int[] lowerArr = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                upperArr[i] = arr[k - i - 1];
                upperArr[k+i] =
                    arr[arr.Length - 1 - i];
            }

            for (int i = 0; i < 2*k; i++)
            {
                lowerArr[i] = arr[i+ k];
            }

            int[] sum = new int[2 * k];

            for (int i = 0; i < 2*k; i++)
            {
                sum[i] = upperArr[i] + lowerArr[i];
            }

            Console.WriteLine(string.Join(' ', sum));
        }
    }
}
