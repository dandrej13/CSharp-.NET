using static System.Console;
using static System.Convert;

int a = 10;
double b = a; // int can be cast into a double
    WriteLine("{0} type is {1}", b, b.GetType);

double c = 9.8;
// int d = c; //compiler gives and error
//WriteLine(d);

double g = 9.8;
    int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}");


