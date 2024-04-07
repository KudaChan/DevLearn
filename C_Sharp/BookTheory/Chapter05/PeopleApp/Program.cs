using Packt.Shared;

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

Book book = new()
{
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform DevelopmentFundamentals"
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