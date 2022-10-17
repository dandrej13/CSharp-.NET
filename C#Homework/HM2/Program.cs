using static System.Console;
using static System.Convert;

WriteLine("Enter a number...");
int a = (ToInt32(ReadLine()));
if (a < 0)
{
    WriteLine($"{a} is a negative number");
} else if (a > 0)
{
    WriteLine($"{a} is a positive number");

} else {
    WriteLine("Number cannot be 0, enter a new one...");
    a = (ToInt32(ReadLine()));
}

WriteLine("");

WriteLine("Enter a number");
int b = (ToInt32(ReadLine()));
if (b != 0)
{
    WriteLine("Enter a second number");
    int c = (ToInt32(ReadLine()));
    if( c != 0)
    {

    WriteLine($"{b} * {c} = {b * c}");
    }
    else { 
        WriteLine("0");
    }
    
}
else
{
    WriteLine("0");
}


WriteLine("");

WriteLine("Enter a number");
    double d = (ToInt32(ReadLine()));
    WriteLine("Enter a second number");
    double e = (ToInt32(ReadLine()));
    if (e != 0)
    {

        WriteLine($"{d} / {e} = {d / e}");
    }
    else
    {
        WriteLine("I cannot divide with 0");
        WriteLine("Enter a second number that is not 0");
        e = (ToInt32(ReadLine()));
}

WriteLine("");

WriteLine("Enter three different numbers");
int f1 = (ToInt32(ReadLine()));
int f2 = (ToInt32(ReadLine()));
int f3 = (ToInt32(ReadLine()));
int GValue = f1;
int[] myArr= {f1, f2, f3};

foreach (int item in myArr)
{
    if(GValue < item)
    {
        GValue = item;
    }
}
WriteLine($"The largest number is: {GValue}");

WriteLine("");

int g =1;

while(g != 0)
{
    WriteLine("Enter a number");
     g = (ToInt32(ReadLine()));
    WriteLine($"{g * 10}");


}

WriteLine("");
int h = 1;
while(h < 10)
{
    WriteLine($"{h}");
    h++;
}

WriteLine("");

WriteLine("Enter a number");
int number;
int sum = 0;

do
{
    Console.Write("Number: ");
    number = Convert.ToInt32(Console.ReadLine());

    sum = number + sum;

    if (number != 0)
        Console.WriteLine("Total: {0}", sum);
}
while (number != 0);

Console.WriteLine("Finished");
