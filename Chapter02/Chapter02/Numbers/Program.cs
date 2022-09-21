// unsigned integer means positive whole number or 0
uint naturalNumber = 23;

// integer means negative or positive whole number or 0
int integerNumber = -23;

// float means singe-precision floating point
//  F suffix makes it a float literal
float realNumber = 2.3F;

// double means double-precision floating point
double anotherRealNumber = 2.3; //double literal

Console.WriteLine(naturalNumber);
Console.WriteLine(integerNumber);
Console.WriteLine(anotherRealNumber);
Console.WriteLine(realNumber);


int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

Console.WriteLine(hexadecimalNotation == binaryNotation);
Console.WriteLine(hexadecimalNotation == decimalNotation);
Console.WriteLine(decimalNotation);
Console.WriteLine(binaryNotation);
Console.WriteLine(hexadecimalNotation);

Console.WriteLine($"int uses {sizeof(int)} bytes" +
    $" and can store number in the range {int.MinValue:N0}" +
    $"to \t"  +
    $"{int.MaxValue:N0}");
Console.WriteLine($"double uses {sizeof(double)} bytes" +
    $" and can store number in the range {double.MinValue:N0}" +
    $"to \t" +
    $"{double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes" +
    $" and can store number in the range {decimal.MinValue:N0}" +
    $"to \t" +
    $"{decimal.MaxValue:N0}");


Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
double result = a + b;
Console.WriteLine(result);
Console.WriteLine(a);
Console.WriteLine(b);
if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does not equal {0.3}");
};


Console.WriteLine("Using decimals:");
decimal c = 0.1M;
decimal d = 0.2M;
decimal results = c + d;
Console.WriteLine(results);
Console.WriteLine(c);
Console.WriteLine(d);
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3}");
}
else
{
    Console.WriteLine($"{c} + {d} does not equal {0.3}");
};