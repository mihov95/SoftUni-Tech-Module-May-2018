using System;

namespace _07Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int ingredientCount = 0;

            while (isRunning)
            {
                string inputIngredient = Console.ReadLine();

                if (inputIngredient == "Bake!")
                {
                    isRunning = false;
                }
                else
                {
                    ingredientCount++;
                    Console.WriteLine($"Adding ingredient {inputIngredient}.");
                }

            }
            Console.WriteLine($"Preparing cake with {ingredientCount} ingredients.");

        }
    }
}
