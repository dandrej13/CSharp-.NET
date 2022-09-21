using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Andrej");
            int num1 = 5;
            Console.WriteLine(num1);
            Func<string> funkcija = () => num1 + " andrej" + num1 * 2 + 3 + 3 + (num1 + 2);
            Console.WriteLine(funkcija());
            char bukva = 'A';
            string tekst = "proben tekst";
            Console.WriteLine(bukva);
            Console.WriteLine(tekst);


        }
    }
}
