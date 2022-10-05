using System;

namespace Ch06Ex03
{
    internal class Program
    {
        static int Additon(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
                return sum;
        }
        static void Main(string[] args)
        {
            //add up all the values in an array
            int[] myArray = { 2, 6, 10, 14 };
            int mySum = Additon(myArray);
            Console.WriteLine($"The sum of the array is {mySum}");
        }
    }
}
