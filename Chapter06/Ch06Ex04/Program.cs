using System;

namespace Ch06Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{args.Length} command line arguments were specified");
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }

            CustomerName myCustomer;
            myCustomer.firstName = "Andrej";
            myCustomer.lastName = "Dimitrievski";
            Console.WriteLine($"{myCustomer.firstName} {myCustomer.lastName}");
        }

        struct CustomerName
        {
            public string firstName, lastName;
        }
    }
}
