using System.Xml;

object height = 1.88;
object name = "Andrej";
Console.WriteLine($"{name} is {height} meters tall");
//int lenghtOf = name.Length;  ERROR
int lenghtOf = ((string)name).Length;
Console.WriteLine(lenghtOf);

//storing a string in a dynamic object
dynamic something = "Mario";

// int does not have a Length property
//something = 12;

// and array of any type has a length property
 something = new[] { 3, 5 ,7 };

// this compiles but would throw an exception at run-time
// if you later  store a data type that does not have a
// property named Length
Console.WriteLine($"Length is {something.Length}");


// good use of var because it avoids the repeated type
//as shown in the more verbose second statement

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();
//bad use of var because we cannot tell the type, so we
//should use a specific type declaration as shown in
//the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");


Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

string[] myArray;
myArray = new string[4];
myArray[0] = "Kate";
myArray[1] = "Jack";
myArray[2] = "Rebbeca";
myArray[3] = "Tom";

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}