using System;
using ClassDemo.Math;


namespace ClassDemo
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Proof of scope of value types
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            // This value type on the other hand will indeed change the person object since 
            // the reference simply points to the object itself
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
