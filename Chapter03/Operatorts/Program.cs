using static System.Console;

int a = 3;
int b = a++;

WriteLine($"Result of a- \"{a}\" and b- \"{b}\" is : {a + b} ");

int c = 3;
int d = ++c;

WriteLine($"Result of c- \"{c}\" and d- \"{d}\" is : {c + d} ");



int f, g;
f = 30;
    g = 7;
double res = Convert.ToDouble(f) / Convert.ToDouble(g);
Console.WriteLine($"{res:N1}");

int h = 11;
int j = 3;

WriteLine($"h is {h}, j is {j}");
WriteLine($"h + j = {h + j}");
WriteLine($"h - j = {h - j}");
WriteLine($"h * j = {h * j}");
WriteLine($"h / j = {Convert.ToDouble(h) / Convert.ToDouble(j)}");
WriteLine($"h % j = {h % j}");


