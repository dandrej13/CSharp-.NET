using System.IO;
using static System.Console;

ForegroundColor = ConsoleColor.Magenta;

string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters");
} else
{
    WriteLine("Your password is strong");
};


object o = 3;
int j = 4;

if (o is int i)
{
    WriteLine($"{i} + {j} = {i + j}");
}   else
{
    WriteLine("o is not int so it can't multiply");
}

Random number = new Random();
int random = number.Next(1, 7);

WriteLine(random);

switch (random)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
        case 3: //multiple case selection
         case 4:
        WriteLine("three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}// end of switch statement

WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");



//string path = @"C:\Users\dimit\OneDrive\Desktop\code22\
//FullStackDevelopment\C#&.NET\Chapter03";

//Write("Press R for read-only or W for writeable: ");
//ConsoleKeyInfo key = ReadKey();
//WriteLine();
//Stream? s;
//if (key.Key == ConsoleKey.R)
//{
//    s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
//}
//else
//{
//    s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Write);   
//}

//string message;

//switch (s)
//{
//    case FileStream writeableFile when s.CanWrite:
//        message = "The stream is a file that i can write to";
//        break;

//    case FileStream readOnlyFile;
//        message = "The stream is a read only file";
//        break;
//    case MemoryStream ms:
//        message = "The stream is a memory address.";
//        break;
//    default:
//        message = "The stream is other type.";
//        break;
//    case null:
//        message = "The steram is null";
//        break;
//}

//WriteLine(message);


string path = @"C:\Users\dimit\OneDrive\Desktop\code22\FullStackDevelopment\C#&.NET\Chapter03";
Write("Press R for read-only or W for writeable: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
Stream? s;
if (key.Key == ConsoleKey.R)
{
    s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
}
else
{
    s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Write);
}
string message;
//switch (s)
//{
//    case FileStream writeableFile when s.CanWrite:
//        message = "The stream is a file that I can write to.";
//        break;
//    case FileStream readOnlyFile:
//        message = "The stream is a read-only file.";
//        break;
//    case MemoryStream ms:
//        message = "The stream is a memory address.";
//        break;
//    default: // always evalueted last despite its current position
//        message = "The stream is some other type.";
//        break;
//    case null:
//        message = "The stream is null.";
//        break;
//}
//WriteLine(message);


message = s switch
{
    FileStream writeableFile when s.CanWrite => "The stream is a file that I can write to.",
    FileStream readOnlyFile => "The stream is a read-only file.",
    MemoryStream ms => "The stream is a memory address.",
    null => "The stream is null.",
    _ => "The stream is null."
};
WriteLine(message);