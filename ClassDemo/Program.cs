using System;
using ClassDemo.Math;


namespace ClassDemo
{
    public enum ShippingMethod
    {
        RegualarAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Value types -- saved in stack
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // Reference type -- when you save the array2 into array1, it is a pointer, not a value
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            // After you change the value of array2[0] it is referenced to the array1[0] and changes single
            // value that's saved on the heap. Only the pointer to the memory location in the heap is saved
            // in the stack. 
            Console.WriteLine(array1[0]);
        }
    }
}
