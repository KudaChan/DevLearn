namespace Packt.Shared;

public partial class Person : Object
{
    #region Fields: Data or state for the person.

    public string? Name;
    public DateTimeOffset Born;

    //public WorndersOfTheAncientWorld FavoriteAncientWonder;
    public WorndersOfTheAncientWorld BucketList;

    public List<Person> Friends = new();

    public const string Species = "Homo Sapiens";

    public readonly string HomePlanet = "Earth";

    public readonly DateTime Instantiated;

    #endregion Fields: Data or state for the person.

    #region Constructors: Called when using new to instantiate a type.

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    #endregion Constructors: Called when using new to instantiate a type.

    #region

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    #endregion

    #region Methods: Actions the type can perform.

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'.";
    }

    public string SayHello(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }

    public string OptionalParameters(int count, string command = "Run!", double number = 0.0, bool active = true)
    {
        return string.Format(
                       format: "command is {0}, number is {1}, active is {2}",
                                  arg0: command, arg1: number, arg2: active);
    }

    #endregion

    #region controlling how parameters are passed

    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        // out parameters cannot have a default
        // AND must be initialized inside the method
        z = 99;

        // increment each parameter
        y++;
        z++;

        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }

    #endregion

    #region Tuples

    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Cherries", Number: 5);
    }

    #endregion

    #region Deconstructor

    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob, out WorndersOfTheAncientWorld bucketList)
    {
        name = Name;
        dob = Born;
        bucketList = BucketList;
    }

    #endregion

    #region Implementing functionality using local functions

    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(
                               $"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);

        int localFactorial(int localNumber)
        {
            if (localNumber < 1)
            {
                return 1;
            }
            return localNumber * localFactorial(localNumber - 1);
        }
    }

    #endregion
}