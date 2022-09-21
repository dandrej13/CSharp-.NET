using static System.Console;


int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
};


string? password;

do
{
    Write("Enter your password: ");
        password = Console.ReadLine();
    WriteLine("Wrong Password");
} while (password != "Pa$$w0rd");

WriteLine("Correct!");


string[] names = { "Stefan", "Alek", "Deni" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters");
}