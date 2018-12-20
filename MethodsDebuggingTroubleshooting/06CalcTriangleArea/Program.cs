using System;

namespace _06CalcTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double widght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(widght, height);

            Console.WriteLine(area);
        }

        static double GetTriangleArea(double widght, double height)
        {
            return widght * height / 2;
        }
    }
}
