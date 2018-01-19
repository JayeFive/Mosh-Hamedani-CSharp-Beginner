using System;
using ClassDemo.Math;


namespace Conditionals
{

    class Program
    {
        static void Main(string[] args)
        {
            // If statements
            int hour = 12;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }


            // Ternary statement
            var isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            // Same as:
            // if (isGoldCustomer)
            //     price = 19.95f;
            // else
            //     price = 29.95f;

            Console.WriteLine(price);


            // Switch statements
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn and beautiful");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's a great day for the beach");
                    break;
                case Season.Spring:
                case Season.Winter:
                    Console.WriteLine("We've got a promotion!");
                    break;
                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
        }
    }
}
