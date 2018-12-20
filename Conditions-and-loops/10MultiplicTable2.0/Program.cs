using System;

namespace _10MultiplicTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{input} X {input2} = {input * input2}");
                input2++;

            } while (input2 <= 10);
        }
    }
}
