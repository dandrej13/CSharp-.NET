using System;

namespace Ch06Ex02
{
    internal class Program
    {
        static int maxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (maxVal < intArray[i])
                {
                    maxVal = intArray[i];
                }
            }
            return maxVal;
        }

        static string GetFirstName(string fullName)
        {
            string res = "";
            if (fullName != null)
            {
                res = fullName.Substring(0, fullName.IndexOf(" "));
            }
            return res;
        }

            static void Main(string[] args)
            {

                // find the highest val in an array
                int[] myArray = { 1, 2, 3, 4, 5, 6, 33, 123, 5 };
            int maxVal = maxValue(myArray);
            Console.WriteLine($"{maxVal} is the largest val in the array");

            }
        
    }

}