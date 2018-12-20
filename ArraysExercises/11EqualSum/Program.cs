using System;
using System.Linq;

namespace _11EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            bool isValid = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                for (int k = i+1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                if (rightSum == leftSum)
                {
                    isValid = true;
                    Console.WriteLine(i);
                    break;
                }
                
            }
            if (isValid == false)
            {
                Console.WriteLine("no");
            }

        }
    }
}
