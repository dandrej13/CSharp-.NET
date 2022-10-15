namespace PeopleLib
{
    public class Person : object
    {
        public string? Name;
        public DateTime DateOfBirth;
        public string? FirstName;
        public List<Person> Children = new();

        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on {DateOfBirth:dddd}");
        }

        public static Person Procreate(Person p1, Person p2)
        {
            Person baby = new Person()
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        //method with a local function

        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                    $"{nameof(number)} cannot be less than zero.");
            }
            return localFactorial(number);

            int localFactorial(int localNumber)// local function
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

    }
}