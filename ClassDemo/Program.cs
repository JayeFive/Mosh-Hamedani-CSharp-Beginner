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
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            // Cast a relational number back to the enum type
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine(method.ToString());

            // How to parse a string back to the enum type
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
