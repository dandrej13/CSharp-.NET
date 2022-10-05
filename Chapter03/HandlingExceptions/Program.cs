using static System.Console;

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();
string message = "NaN";
try
{
    byte age = byte.Parse(input);
    Console.WriteLine($"You are {age} years old" );
}
catch (FormatException ex)
{
    WriteLine($"FormatException says {message}");
}
catch (OverflowException ex)
{
    Console.WriteLine($"Your input valid but is too small or large");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {message}");
}
WriteLine("After Parsing");