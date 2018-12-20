using System;

namespace _04DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            TopAndBotRows(n);
            for (int i = 0; i < n/2; i++)
            {
                MiddlePart(n);
            }
            TopAndBotRows(n);
        }


        static void TopAndBotRows(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void MiddlePart(int n)
        {
            Console.Write('-');

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.Write('-');

            Console.WriteLine();
        }

    }
}
