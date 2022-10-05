using System;
using static System.Console;

namespace Ch04Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intOverflow = (int.MaxValue);

            WriteLine($"Min value of int {int.MinValue}");
            WriteLine($"Max value of int {int.MaxValue}");
            WriteLine($"Overflow by one: {++intOverflow}");
        }
    }
}
