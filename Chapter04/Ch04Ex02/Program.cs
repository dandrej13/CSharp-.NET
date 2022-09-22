using System;

namespace Ch04Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comparison;
            Console.WriteLine("Enter a number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a < b)
            {
                comparison = "smaller than";
            }
            else if (a == b)
            {
                comparison = "equal to";
            }
            else
            {
                comparison = "greater than";
            }

            Console.WriteLine($"{a} is {comparison} {b}");
            Console.ReadKey();


        }
    }
}