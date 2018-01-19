using System;
using ClassDemo.Math;


namespace Excersizes
{

    class Program
    {
        static void Main(string[] args)
        {
            // Get number from user. Print 'valid' if it's between 1-10 and 'invalid' otherwise
            Console.WriteLine("Enter a number between 1 and 10: ");
            var input = int.Parse(Console.ReadLine());
            

            if (input > 0 && input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }


            // Get 2 numbers, display larger 
            Console.WriteLine("Please enter a number: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            var num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(string.Format("{0} is bigger than {1}", num1, num2));
            }
            else if (num1 < num2)
            {
                Console.WriteLine(string.Format("{0} is bigger than {1}", num2, num1));
            }
            else
            {
                Console.WriteLine("The numbers are the same");
            }


            // Get width and height from the user and print 'landscape' or 'portrait'
            Console.WriteLine("Please enter the width of a picture: ");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of the picture: ");
            var height = int.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("This picture is a landscape");
            }
            else if (width < height)
            {
                Console.WriteLine("This picture is a portrait");
            }
            else
            {
                Console.WriteLine("This picture is perfectly square!");
            }


            // Speed camera exercise. Ask user for speed limit. Ask for speed of car.
            // Display 'ok' if under the speed limit. If it's over the speed limit display
            // the number of demerits. 1 demerit per 5km/h. Over 12 demerits, display 
            // 'License Suspended'

            Console.WriteLine("Enter the speed Limit: ");
            var speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car: ");
            var carSpeed = int.Parse(Console.ReadLine());

            const int demeritScale = 5;

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Speed OK!");
            }
            else
            {
                var speedOverLimit = carSpeed - speedLimit;
                var numDemerits = speedOverLimit / demeritScale;
                numDemerits += 1;   // 1-5 over should give a demerit

                if (numDemerits > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("You have received " + numDemerits + " demerits!");
                }
            }
        }
    }
}
