using static System.Console;
static string CardinalToOrdinal(int number)
{
    switch (number)
    {
        case 11: // special cases for 11th to 13th
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}


static void RunCardinalToOrdinal()
{
    for (int number = 1; number <= 40; number++)
    {
        Write($"{CardinalToOrdinal(number)} ");
    }
    WriteLine();
}
RunCardinalToOrdinal();


    static int Factorial(int number)
{
    if (number < 0)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked {  //for overflow
        int returnVal = Factorial(number - 1);
        int res = number * returnVal;
        return res;
    }
    }
}

    static void RunFactorial()
{
    for (int i = 1; i < 15; i++)
    {
        try
        {
        WriteLine($"{i}! = {Factorial(i):N0}");

        }
        catch (OverflowException ex)
        {
            WriteLine($"{i}1 is too large for 32-bit integer" );
        }
    }
}

RunFactorial();