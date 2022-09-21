using static System.Console;

int a = 10; // 00001010;
int b = 6; // 00000110;
WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}"); //2-bit column only
WriteLine($"a | b = {a | b}"); //8, 4 and 2 columns only
WriteLine($"a ^ b = {a ^ b}"); //8 and 4 bit columns only


// 01010000 left-shift "a" by three bit columns
WriteLine($"a << 3  = {a << 3}");

 static string ToBinaryString(int value)
{
  return Convert.ToString(value, toBase:2).PadLeft(8, '0');
}
WriteLine();
WriteLine("Outputting integers as binary:");
WriteLine($"a = {ToBinaryString(a)}");
WriteLine($"b = {ToBinaryString(b)}");