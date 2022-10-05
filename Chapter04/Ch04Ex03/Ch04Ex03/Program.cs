using System;
using System.Linq;

namespace Ch04Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] niceNames = { "Andrej", "Mario", "Stefan" };
            string[] notNiceNames = { "asddd", "bsdd", "tsstt" };
            Console.WriteLine("Please enter your name.");
            string input = Convert.ToString(Console.ReadLine());
            ///boring
            ///
            foreach (string namen in niceNames) ;

            switch (input)
            {
                case namen:
                    Console.WriteLine("asdasd");
            }
            
                  
        }
    }
}
