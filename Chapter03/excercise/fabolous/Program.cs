using System;

namespace fabolous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            super.smashing.Great great = new super.smashing.Great();
            Console.WriteLine("Hello World!");
            Console.WriteLine($"My age is : {great.Age}");
            Console.WriteLine("Enter a new age: ");
            great.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"New age is: {great.Age}");
        }
    }
}
