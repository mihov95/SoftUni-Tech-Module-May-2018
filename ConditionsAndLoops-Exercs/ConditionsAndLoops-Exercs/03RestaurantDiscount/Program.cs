using System;

namespace _03RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string packet = Console.ReadLine();
            double hallPrice = 0.00;
            string hallName = "";

            if (people <= 50)
            {
                hallPrice = 2500;
                hallName = "Small Hall";
            }
            else if (people <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";

            }
            else if (people <=120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";

            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }


            double discount = 0;
            double packetPrice = 0.00;

            if (packet == "Normal")
            {
                discount = 0.05;
                packetPrice = 500;
            }
            else if (packet == "Gold")
            {
                discount = 0.10;
                packetPrice = 750;
            }
            else if (packet == "Platinum")
            {
                discount = 0.15;
                packetPrice = 1000;
            }

            double totalPrice = hallPrice + packetPrice;
            double discountPrice = totalPrice - totalPrice * discount;
            double personPrice = discountPrice / people;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {personPrice:f2}$");
        }
    }
}
