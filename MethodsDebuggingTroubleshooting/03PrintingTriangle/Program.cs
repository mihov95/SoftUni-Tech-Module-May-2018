using System;

namespace _03PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTopPart(num);
            PrintBottomPart(num);

        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTopPart(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }
        }

        static void PrintBottomPart(int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);

            }
        }
    }
}
