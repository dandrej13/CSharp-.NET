using System;
using System.Runtime.Intrinsics.Arm;

namespace Ch04Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate in %?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What is your current targeted balance?");
            targetBalance = Convert.ToDouble(Console.ReadLine());

            int totalYears = 0;
            while (targetBalance <= balance)
            {
                Console.WriteLine("Target balance must be greater than your current balance. Please enter a new target: ");
                targetBalance = Convert.ToDouble(Console.ReadLine());

            }
            while (balance < targetBalance)
            {
                balance *= interestRate;
                totalYears++;
            }

            Console.WriteLine($"In {totalYears} year {(totalYears == 1? "":"s")} you will have {balance}");

            if (totalYears == 0)
            {
                Console.WriteLine("You didn't need a calculator for this");

            }

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            while(num1 > 10 && num2 > 10)
            {
                Console.WriteLine("Both nums are > 10. Enter new ones:");
                 num1 = Convert.ToInt32(Console.ReadLine());
                 num2 = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"{num1} is {(num1 < 10 ? "smaller" : "equal or greater")} than 10");
            Console.WriteLine($"{num2} is {(num2 < 10 ? "smaller" : "equal or greater")} than 10");
        }
    }
}
