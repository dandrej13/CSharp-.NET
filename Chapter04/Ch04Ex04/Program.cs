using System;

namespace Ch04Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            Console.WriteLine("Enter your current balance: ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your current annual rate: (in %) ");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("Enter your targeted balance: ");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            do
            {
                balance *= interestRate;
                ++totalYears;
            }while(balance < targetBalance);
            Console.WriteLine($"In {totalYears} year{(totalYears == 1? "":"s")} you will have a balance of {balance}");
        }
    }
}
