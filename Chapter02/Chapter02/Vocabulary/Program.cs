// See https://aka.ms/new-console-template for more information
//#error version
using System.Reflection;

System.Data.DataSet ds;
HttpClient client;
List<string> list;

Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) return;

//Loop the assembly so we can read its details
foreach(AssemblyName name in assembly.GetReferencedAssemblies())
{
    //Load the assembly so we can read the deteails
    Assembly a = Assembly.Load(name);

    // declare a variable to count the number of methods
    int methodCount=0;

    // Loop through all the types in the assembly
     foreach(TypeInfo t in a.DefinedTypes)
    {
    //  add up the counts of methods
        methodCount += t.GetMethods().Count();
    }
    //output the count of types and their methods
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name
        );


   

}
    double heightInMeters = 1.88;
    Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}");

    char letter = 'A';
    char digit = '1';
    char symbol = '$';
    //char userChoice = Console.ReadKey().KeyChar;
    char userChoice = 'z';

Console.WriteLine($"{nameof(letter)} : {letter} \r\n" +
                  $"{nameof(digit)}  :  {digit} \r\n" +
                  $"{nameof(symbol)}  :  {symbol} \r\n" +
                  $"{nameof(userChoice)}  :  {userChoice} \r\n");

string firstName = "Bob";
string lastName = "Smith";
string phoneNumber = "(243) 255-000";

Console.WriteLine($"{nameof(firstName)} : {firstName} \r\n" +
                  $"{nameof(lastName)}  :  {lastName} \r\n" +
                  $"{nameof(phoneNumber)}  :  {phoneNumber} \r\n");

string fullNameWithTabSeparator = "Bob\tSmith";
Console.WriteLine(fullNameWithTabSeparator);

string filePath = @"C:\televison\image\error";
string filePath2 = "C:\\televison\\image\\error";
Console.WriteLine($"{filePath} \r\n {filePath2}");
