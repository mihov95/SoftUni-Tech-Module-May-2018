using System;

namespace _01BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT" + 
                Environment.NewLine +
                new string ('-', 30));
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to" + new string ('_', 20));
            Console.WriteLine("Received by" + new string ('_', 19));
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
