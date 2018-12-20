using System;
using System.Linq;

namespace _08MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxNumber = 0;
            int maxCounter = 0;

            for (int i = 0; i < numbersArr.Length; i++)
            {
                int counter = 0;

                for (int j = i; j < numbersArr.Length; j++)
                {
                    if (numbersArr[i] == numbersArr[j])
                    {
                        counter++;
                    }
                }

                if (counter > maxCounter)
                {
                    counter = maxCounter;
                    maxNumber = numbersArr[i];
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
