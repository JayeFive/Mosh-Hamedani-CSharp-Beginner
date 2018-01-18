using System;
using ClassDemo.Math;


namespace ClassDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Johnny";
            var lastName = "Olson";

            // string.Format is the same, just easier to read
            var myFullName = firstName + " " + lastName;
            var fullName = string.Format("{0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            // Verbatim strings. These two have the same output
            var text = "Hi John\nLook into the following paths:\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            var textVerbatim = @"Hi John
Look into the following paths:
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(textVerbatim);
        }
    }
}
