using System;

namespace _04SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primeArr = new bool[n];

            for (int i = 0; i < primeArr.Length; i++)
            {
                primeArr[i] = true;
            }

            if (primeArr.Length == 1)
            {
                primeArr[0] = true;
            }
            else
            {
            primeArr[0] = false;
            primeArr[1] = false;

            }


            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                primeArr[i] = true;

                if (primeArr[i])
                {
                    for (int j = i*i; j < n; j+=i)
                    {
                        primeArr[j] = false;
                    }
                }
            }

            for (int i = 2; i < n; i++)
            {
                if (primeArr[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
