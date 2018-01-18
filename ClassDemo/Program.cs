using System;
using ClassDemo.Math;


namespace ClassDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Johnny";
            string lastName = "Olson";

            string name = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(name);

            // string.Join
            var numbers = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numbers);

            // Verbatim strings: These 2 are equal
            string path = "c:\\programs\\users\\johnny";
            string path2 = @"c:\programs\users\johnny";
        }
    }
}
