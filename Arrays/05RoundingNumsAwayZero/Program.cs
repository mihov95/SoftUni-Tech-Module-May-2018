using System;
using System.Linq;

namespace _05RoundingNumsAwayZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(double.Parse).ToArray();

            //foreach (var item in arr)
            //{
            //    var roundedNum = Math.Round(item, MidpointRounding.AwayFromZero);

            //    Console.WriteLine($"{item} => {roundedNum}");
            //}

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
