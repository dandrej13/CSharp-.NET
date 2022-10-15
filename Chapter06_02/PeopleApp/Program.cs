using PeopleLib;
using static System.Console;

Person harry = new Person() { Name = "Harry" };
Person marry = new Person() { Name = "Marry" };
Person jill = new Person() { Name = "Jill" };

// instance method
Person baby1 = marry.ProcreateWith(harry);
baby1.Name = "Garry";

// static method
Person baby2 = Person.Procreate(harry, jill);
baby2.Name = "Steve";

//opreator
Person baby3 = harry * marry;


WriteLine($"{harry.Name} has {harry.Children.Count} children");
WriteLine($"{marry.Name} has {marry.Children.Count} children");
WriteLine($"{jill.Name} has {jill.Children.Count} children");
WriteLine(
    format: "{0}'s first child's name is \"{1}\".",
    arg0: harry.Name,
    arg1: harry.Children[1].Name
    );