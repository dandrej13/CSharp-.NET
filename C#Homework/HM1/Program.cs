using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Console;

WriteLine("Andrej \nDimitrievski");
WriteLine("");

WriteLine($"Result of adding 12 and 13 is = {12 + 13}");
WriteLine($"Result of dividing 24 into 5 is = {24 / 5}");
WriteLine("");

WriteLine($"Result of -1 + 3 * 5 is = {-1 + 3 * 5}" +
          $"\nResult of (24+5) % 7  is = {(24 + 5) % 7}" +
          $"\nResult of 15 + -4*6 / 11 is = {15 + -4 * 6 / 11}" +
          $"\nResult of 2 + 10 / 6 * 1 - 7 % 2 is = {2 + 10 / 6 * 1 - 7 % 2}");

WriteLine("");

WriteLine($"Enter two numbers and press enter after each one of them to multiply them...");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int res = a * b;
WriteLine($"The result of multiplying {a} and {b} is equal to {res}");

WriteLine("");

WriteLine($"Enter the first number to multiply ...");
int aa = Convert.ToInt32(Console.ReadLine());
WriteLine($"Enter the second number to multiply ...");
int bb = Convert.ToInt32(Console.ReadLine());
WriteLine($"Enter the third number to multiply ...");
int cc = Convert.ToInt32(Console.ReadLine());
int ress = aa * bb * cc;
WriteLine($"The result of multiplying {aa} and {bb} and {cc} is equal to {ress}");

WriteLine("");

Write($"Enter a number: ");
int aaa = Convert.ToInt32(Console.ReadLine());

Write($"Enter a second number: ");
int bbb = Convert.ToInt32(Console.ReadLine());
int add = aaa + bbb;
int sub = aaa - bbb;
int mul = aaa * bbb;
int div = aaa / bbb;
int rem = aaa % bbb;

WriteLine($"{aaa} + {bbb} = {add}" +
    $"\n{aaa} - {bbb} = {sub}" +
    $"\n{aaa} * {bbb} = {mul}" +
    $"\n{aaa} / {bbb} = {div}" +
    $"\n{aaa} % {bbb} = {rem}");

WriteLine("");

WriteLine("Enter a number to get a multiplication table with it...");
int multi = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < 11; i++)
{
    WriteLine($"{multi} * {i} = {multi * i}");
}

WriteLine("");

WriteLine("Enter four different numbers to get their average");
double z = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double x = Convert.ToDouble(Console.ReadLine());
double q = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The average of {z}, {y}, {x} and {q} is {(z + y + x + q) / 4}");


int num;

Console.WriteLine("Enter a digit: ");
num = Convert.ToInt32(Console.ReadLine());

Console.Write(num);
Console.Write(" ");
Console.Write(num);
Console.Write(" ");
Console.Write(num);
Console.Write(" ");
Console.Write(num);
Console.WriteLine();

Console.Write(num);
Console.Write(num);
Console.Write(num);
Console.WriteLine(num);
Console.WriteLine();

Console.WriteLine("{0} {0} {0} {0}", num);
Console.WriteLine("{0}{0}{0}{0}", num);

//Write a C# program to ask the user for a number and then display a rectangle 3 columns wide 
//and 5 rows tall using that digit. For example: 

//Enter a digit: 3
//333
//3 3
//3 3
//3 3
//333

Write("Enter a number...");
int rec = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 5; i++)
{
    WriteLine($"{rec} {rec} {rec}");
    
}


WriteLine("Enter Celsius to be converted to Fahrenheit: ");
double c = Convert.ToInt32(Console.ReadLine());
WriteLine($"{c} Celsius is equal to {c * 18 / 10 + 32} Fahrenheit");
WriteLine($"{c} Celsius is equal to {c + 273} Kelvin");

