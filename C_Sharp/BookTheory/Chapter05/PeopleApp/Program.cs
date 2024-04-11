using Packt.Shared;

using Fruit = (string Name, int Number);

ConfigureConsole();

Person bob = new Person();
bob.Name = "Bob Smith";

bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 7, minute: 30, second: 0,
    offset: TimeSpan.FromHours(-5));

//WriteLine(
//       format: "{0} was born on {1:dddd, d MMMM, yyyy} at {1:hh:mm tt}",
//          arg0: bob.Name, arg1: bob.Born);

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
    TimeSpan.Zero)
};

//WriteLine(format: "{0} was born on {1:d}.",
//    arg0: alice.Name, arg1: alice.Born);

Person chandan = new()
{
    Name = "Chandan Kumar",
    Born = new DateTimeOffset(
        year: 2002, month: 07, day: 05,
        hour: 9, minute: 15, second: 0,
        offset: TimeSpan.FromHours(+5)),
    //FavoriteAncientWonder = WorndersOfTheAncientWorld.GreatPyramidOfGiza
    BucketList = WorndersOfTheAncientWorld.GreatPyramidOfGiza | WorndersOfTheAncientWorld.HangingGardensOfBabylon,
};

chandan.Friends.Add(bob);
chandan.Friends.Add(new Person { Name = "Chintu" });
chandan.Friends.Add(new() { Name = "Chinti" });

WriteLine("");

WriteLine(
    format: "{0} was born on {1:dddd, d MMMM, yyyy} at {1:hh:mm tt}. His bucketlist to visit is {2}",
    arg0: chandan.Name,
    arg1: chandan.Born,
    arg2: chandan.BucketList);
WriteLine($"{chandan.Name} is a {Person.Species}.");
WriteLine($"{chandan.Name} lives on planet {chandan.HomePlanet}.");
WriteLine($"{chandan.Name} has {chandan.Friends.Count} friends:");

for (int childIndex = 0; childIndex < chandan.Friends.Count; childIndex++)
{
    WriteLine($">{chandan.Friends[childIndex].Name}");
}

WriteLine("");

BankAccount.InterestRate = 0.012M;

BankAccount chandanAccount = new();
chandanAccount.AccountName = chandan.Name;
chandanAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
       arg0: chandanAccount.AccountName,
          arg1: chandanAccount.Balance * BankAccount.InterestRate);

BankAccount miniAccount = new();
miniAccount.AccountName = chandan.Name + " mini";
miniAccount.Balance = 100;
WriteLine(format: "{0} earned {1:C} interest.",
          arg0: miniAccount.AccountName,
          arg1: miniAccount.Balance * BankAccount.InterestRate);

WriteLine("");

//Book book = new()
//{
//    Isbn = "978-1803237800",
//    Title = "C# 12 and .NET 8 - Modern Cross-Platform DevelopmentFundamentals"
//};

Book book = new(isbn: "978-1803237800", title: "C# 12 and .NET 8 - Modern Cross-Platform DevelopmentFundamentals")
{
    Author = "Mark J. Price",
    PageCount = 800
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
    book.Isbn, book.Title, book.Author, book.PageCount);

WriteLine("");

Person blankPerson = new();

WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");

WriteLine(format:
       "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
          arg0: gunny.Name,
             arg1: gunny.HomePlanet,
                arg2: gunny.Instantiated);

WriteLine("");

bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine("");

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));

WriteLine("");

WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3, "Jump!", 98.5));

WriteLine(bob.OptionalParameters(3, number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters(3, "poke!", active: false));

WriteLine("");

int a = 10;
int b = 20;
int c = 30;
int d = 40;

WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

int e = 50;
int f = 60;
int g = 70;

WriteLine($"Before: e={e}, f={f}, g={g} h doesn't exist yet!");
bob.PassingParameters(e, f, ref g, out int h);
WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

WriteLine("");

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

WriteLine("");

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

WriteLine("");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (chandan.Name, chandan.Friends.Count);
WriteLine($"{thing2.Name} has {thing2.Count} friends.");

WriteLine("");

Fruit fruitNamed2 = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed2.Number} {fruitNamed2.Name}.");

WriteLine("");

(string Name, int Number) = bob.GetNamedFruit();
WriteLine($"Deconstructed: {Name}, {Number}");

WriteLine("");

var (name1, dob1) = bob;
WriteLine($"Deconstructed person: {name1}, {dob1}");

var (name2, dob2, fav2) = chandan;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

WriteLine("");

int number = 5;

try
{
    WriteLine($"{number}! = {Person.Factorial(number)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
}