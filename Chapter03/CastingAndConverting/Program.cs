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

//alocate array of 128 bytes
byte[] binaryObject = new byte[128];

//populate array with random bytes
(new Random()).NextBytes(binaryObject);

WriteLine("Binary Object as bytes");

for (int i = 0; i < binaryObject.Length; i++)
{
    Write($"{binaryObject[i]:X} ");
};

WriteLine();

//convert to Base64 string and output the text
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary object into Base64 is: {encoded} ");

int age = int.Parse("23");

DateTime birthday = DateTime.Parse("13 December 1998");

WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");
