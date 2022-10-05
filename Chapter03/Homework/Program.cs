using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            Console.WriteLine("byte's range is 255. please enter new number from 0 to 255");
            max = Convert.ToByte(Console.ReadLine());
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);

            }

            for (int i = 1; i < 101; i++)
            {
                //if (i % 3 != 0 && i % 5 != 0 && i % 15 != 0)
                //{
                //    Console.Write($"{i}, ");
                //} else
                //{
                //    if (i % 3 == 0 ^ i % 15 == 0)
                //    {
                //        Console.Write("fizz, ");
                //    } else
                //    {
                //        if (i % 5 == 0 ^ i % 15 == 0)
                //        {
                //            Console.Write("buzz, ");
                //        } else
                //        {

                //            if(i % 15 == 0)
                //            {
                //                Console.Write("fizzBuzz, ");
                //            }
                //        }
                //    }
                //}
                if (i % 15 == 0)
                {
                    Console.Write("fizzBuzz, ");
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        Console.Write("Buzz, ");
                    }
                    else
                    {
                        if (i % 3 == 0)
                        {
                            Console.Write("fizz, ");
                        }
                        else
                        {
                            if (i % 1 == 0)
                            {
                                Console.Write($"{i}, ");
                            }
                        }
                    }


                }
            }
        }
    }
}
