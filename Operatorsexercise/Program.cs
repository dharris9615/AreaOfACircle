using System;

namespace Operatorsexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;

            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            
           

            Console.WriteLine("What is the radius of your circle?");
            var pi = Math.PI;
            var r = double.Parse(Console.ReadLine());

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($" The area of a circle with radius of {r} is {areaOfCircle}");
        }
    }
}
