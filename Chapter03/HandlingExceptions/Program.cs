using static System.Console;

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();
string message = "NaN";
try
{
    int age = int.Parse(input);
    Console.WriteLine($"You are {age} years old" );
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType()} says {message}");
}
WriteLine("After Parsing");