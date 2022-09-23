using System;

namespace Ch03Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name!");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName} !");
            Console.WriteLine("Please give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me a second number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: " +
                $"{firstNumber + secondNumber} ");
            Console.WriteLine($"The sum of subtracting {firstNumber} and {secondNumber} is: " +
                $"{firstNumber - secondNumber} ");
            Console.WriteLine($"The sum of multiplying {firstNumber} and {secondNumber} is: " +
                $"{firstNumber * secondNumber} ");
        }
    }
}
