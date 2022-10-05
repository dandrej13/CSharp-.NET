using static System.Console;

static void TimeTable(byte number)
{
    WriteLine($"This is the {number} times table");

    for (int row = 0; row <= 12; row++)
    {
        WriteLine($"{row} * {number} = {row * number}");
    }
        WriteLine();
}
 ;

byte input = 0;


try
{
    {
        WriteLine("Enter a number between 1 and 255");
        input = Convert.ToByte(ReadLine());
        TimeTable(input);
    }
}

catch (Exception ex)
{
    
    WriteLine("Invalid number! Enter a number between 1 and 255");
    input = Convert.ToByte(ReadLine());
    TimeTable(input);
}

////////////////////////////////////
///

static decimal CalculateTax(
    decimal amount, string twoLetterRegionCode)
{
    decimal rate = 0.0M;

    switch (twoLetterRegionCode.ToUpper())
    {
        case "CH": //Switzerland
            rate = 0.08M;
            break;
        case "DK": // Denmark
        case "NO": // Norway
            rate = 0.25M;
            break;
        case "GB": // Great Britain
        case "FR": // France
            rate = 0.2M;
            break;
        case "HU": // Hungary
            rate = 0.27M;
            break;
        case "OR": // Oregon
        case "AK": // Alaska
        case "MT": // Montana
            rate = 0.0M;
            break;
        case "ND": // North Dakota
        case "WI": // Wisconsin
        case "ME": // Maine
        case "VA":
            rate = 0.05M;
            break;
        case "CA": // California
            rate = 0.0825M;
            break;
        default:
            rate = 0.06M; //avg US states
            break;
    }
    return amount * rate;
}

decimal tax = CalculateTax(100, "CH");

WriteLine($"The amount of tax you have to pay is : ${tax}");