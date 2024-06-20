using Packt.Shared;

using Fruit = (string Name, int Number);

ConfigureConsole();

#region Person class implementation

//Person bob = new Person();
//bob.Name = "Bob Smith";

//bob.Born = new DateTimeOffset(
//    year: 1965, month: 12, day: 22,
//    hour: 7, minute: 30, second: 0,
//    offset: TimeSpan.FromHours(-5));

////WriteLine(
////       format: "{0} was born on {1:dddd, d MMMM, yyyy} at {1:hh:mm tt}",
////          arg0: bob.Name, arg1: bob.Born);

//Person alice = new()
//{
//    Name = "Alice Jones",
//    Born = new(1998, 3, 7, 16, 28, 0,
//    TimeSpan.Zero)
//};

////WriteLine(format: "{0} was born on {1:d}.",
////    arg0: alice.Name, arg1: alice.Born);

//Person chandan = new()
//{
//    Name = "Chandan Kumar",
//    Born = new DateTimeOffset(
//        year: 2002, month: 07, day: 05,
//        hour: 9, minute: 15, second: 0,
//        offset: TimeSpan.FromHours(+5)),
//    //FavoriteAncientWonder = WorndersOfTheAncientWorld.GreatPyramidOfGiza
//    BucketList = WorndersOfTheAncientWorld.GreatPyramidOfGiza | WorndersOfTheAncientWorld.HangingGardensOfBabylon,
//};

//chandan.Friends.Add(bob);
//chandan.Friends.Add(new Person { Name = "Chintu" });
//chandan.Friends.Add(new() { Name = "Chinti" });

//WriteLine("");

//WriteLine(
//    format: "{0} was born on {1:dddd, d MMMM, yyyy} at {1:hh:mm tt}. His bucketlist to visit is {2}",
//    arg0: chandan.Name,
//    arg1: chandan.Born,
//    arg2: chandan.BucketList);
//WriteLine($"{chandan.Name} is a {Person.Species}.");
//WriteLine($"{chandan.Name} lives on planet {chandan.HomePlanet}.");
//WriteLine($"{chandan.Name} has {chandan.Friends.Count} friends:");

//for (int childIndex = 0; childIndex < chandan.Friends.Count; childIndex++)
//{
//    WriteLine($">{chandan.Friends[childIndex].Name}");
//}

//WriteLine("");

//BankAccount.InterestRate = 0.012M;

//BankAccount chandanAccount = new();
//chandanAccount.AccountName = chandan.Name;
//chandanAccount.Balance = 2400;
//WriteLine(format: "{0} earned {1:C} interest.",
//       arg0: chandanAccount.AccountName,
//          arg1: chandanAccount.Balance * BankAccount.InterestRate);

//BankAccount miniAccount = new();
//miniAccount.AccountName = chandan.Name + " mini";
//miniAccount.Balance = 100;
//WriteLine(format: "{0} earned {1:C} interest.",
//          arg0: miniAccount.AccountName,
//          arg1: miniAccount.Balance * BankAccount.InterestRate);

//WriteLine("");

////Book book = new()
////{
////    Isbn = "978-1803237800",
////    Title = "C# 12 and .NET 8 - Modern Cross-Platform DevelopmentFundamentals"
////};

//Book book = new(isbn: "978-1803237800", title: "C# 12 and .NET 8 - Modern Cross-Platform DevelopmentFundamentals")
//{
//    Author = "Mark J. Price",
//    PageCount = 800
//};

//WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
//    book.Isbn, book.Title, book.Author, book.PageCount);

//WriteLine("");

//Person blankPerson = new();

//WriteLine(format:
//    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
//    arg0: blankPerson.Name,
//    arg1: blankPerson.HomePlanet,
//    arg2: blankPerson.Instantiated);

//Person gunny = new(initialName: "Gunny", homePlanet: "Mars");

//WriteLine(format:
//       "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
//          arg0: gunny.Name,
//             arg1: gunny.HomePlanet,
//                arg2: gunny.Instantiated);

//WriteLine("");

//bob.WriteToConsole();
//WriteLine(bob.GetOrigin());

//WriteLine("");

//WriteLine(bob.SayHello());
//WriteLine(bob.SayHello("Emily"));

//WriteLine("");

//WriteLine(bob.OptionalParameters(3));
//WriteLine(bob.OptionalParameters(3, "Jump!", 98.5));

//WriteLine(bob.OptionalParameters(3, number: 52.7, command: "Hide!"));
//WriteLine(bob.OptionalParameters(3, "poke!", active: false));

//WriteLine("");

//int a = 10;
//int b = 20;
//int c = 30;
//int d = 40;

//WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
//bob.PassingParameters(a, b, ref c, out d);
//WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

//int e = 50;
//int f = 60;
//int g = 70;

//WriteLine($"Before: e={e}, f={f}, g={g} h doesn't exist yet!");
//bob.PassingParameters(e, f, ref g, out int h);
//WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

//WriteLine("");

//(string, int) fruit = bob.GetFruit();
//WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

//WriteLine("");

//var fruitNamed = bob.GetNamedFruit();
//WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

//WriteLine("");

//var thing1 = ("Neville", 4);
//WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

//var thing2 = (chandan.Name, chandan.Friends.Count);
//WriteLine($"{thing2.Name} has {thing2.Count} friends.");

//WriteLine("");

//Fruit fruitNamed2 = bob.GetNamedFruit();
//WriteLine($"There are {fruitNamed2.Number} {fruitNamed2.Name}.");

//WriteLine("");

//(string Name, int Number) = bob.GetNamedFruit();
//WriteLine($"Deconstructed: {Name}, {Number}");

//WriteLine("");

//var (name1, dob1) = bob;
//WriteLine($"Deconstructed person: {name1}, {dob1}");

////var (name2, dob2, fav2) = chandan;
////WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

//WriteLine("");

//int number = 5;

//try
//{
//    WriteLine($"{number}! = {Person.Factorial(number)}");
//}
//catch (Exception ex)
//{
//    WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
//}

//WriteLine("");

//Person sam = new()
//{
//    Name = "Sam",
//    Born = new(1986, 2, 27, 0, 0, 0, TimeSpan.Zero)
//};

//WriteLine(sam.Origin);
//WriteLine(sam.Greeting);
//WriteLine(sam.Age);

//WriteLine("");

//sam.FavoriteIceCream = "Chocolate";
//WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

//string color = "Red";

//try
//{
//    sam.FavoutitePrimaryColor = color;
//    WriteLine($"Sam's favorite color is {sam.FavoutitePrimaryColor}.");
//}
//catch (Exception ex)
//{
//    WriteLine("Tried to set {0} to '{1}': {2}",
//        nameof(sam.FavoutitePrimaryColor), color, ex.Message);
//}

//chandan.FavoriteAncientWonder = (WorndersOfTheAncientWorld)4;
//WriteLine($"{chandan.Name}'s favorite ancient wonder is {chandan.FavoriteAncientWonder}.");

//WriteLine("");

//bob.Friends.Add(new() { Name = "Charlie", Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero) });
//bob.Friends.Add(new() { Name = "Daisy", Born = new(2019, 11, 23, 0, 0, 0, TimeSpan.Zero) });

//WriteLine($"Bob's first child is {bob.Friends[0].Name}");
//WriteLine($"Bob's second child is {bob.Friends[1].Name}");

//WriteLine($"Bob's first child is {bob[0].Name}");
//WriteLine($"Bob's second child is {bob[1].Name}");

//WriteLine($"Bob's friend named Daisy is {bob["Daisy"].Age} years old.");

#endregion Person class implementation

#region Passengers class implementation

//Passenger[] passengers =
//{
//    new FirstClassPassenger { Name = "Alice", AirMiles = 1_419 },
//    new FirstClassPassenger { Name = "Bob", AirMiles = 41_000 },
//    new BusinessClassPassenger { Name = "Charlie" },
//    new CoachClassPassenger { Name = "Daisy", CarryOnKG = 25.7 },
//    new CoachClassPassenger { Name = "Eve", CarryOnKG = 0 },
//};

//foreach (Passenger passenger in passengers)
//{
//    decimal flightCost = passenger switch
//    {
//        //FirstClassPassenger p when p.AirMiles > 30_000 => 1500M,
//        //FirstClassPassenger p when p.AirMiles > 15_000 => 1750M,
//        //FirstClassPassenger _ => 2000M,
//        FirstClassPassenger p => p.AirMiles switch
//        {
//            > 30_000 => 15000M,
//            > 15_000 => 17500M,
//            _ => 2000M
//        },
//        BusinessClassPassenger _ => 10000M,
//        //CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
//        //CoachClassPassenger _ => 650M,
//        CoachClassPassenger p => p.CarryOnKG switch
//        {
//            < 10.0 => 5000M,
//            _ => 6500M
//        },
//        _ => 8000M
//    };

//    WriteLine($"Flight costs {flightCost:C} for {passenger}");
//}

#endregion Passengers class implementation

#region Init-Only properties

//ImmumatablePerson jeff = new()
//{
//    FirstName = "Jeff",
//    LastName = "Winger"
//};

////jeff.FirstName = "Geoff";

#endregion Init-Only properties

#region Record types

//ImmutableVehicle car = new()
//{
//    Wheels = 4,
//    Color = "Red",
//    Brand = "Toyota"
//};
//ImmutableVehicle repaintdCar = car with { Color = "Pink" };

//WriteLine("Original car: {0}, {1}, {2}",
//       arg0: car.Color, arg1: car.Brand, arg2: car.Wheels);

//WriteLine("Repainted car: {0}, {1}, {2}",
//       arg0: repaintdCar.Color, arg1: repaintdCar.Brand, arg2: repaintdCar.Wheels);

#endregion Record types

#region Equality of record types

//AnimalClass ac1 = new() { Name = "Rex" };
//AnimalClass ac2 = new() { Name = "Rex" };

//WriteLine($"ac1 == ac2: {ac1 == ac2}");

//AnimalRecord ar1 = new() { Name = "Rex" };
//AnimalRecord ar2 = new() { Name = "Rex" };

//WriteLine($"ar1 == ar2: {ar1 == ar2}");

#endregion Equality of record types

#region Positional data members in records

//ImmutableAnimal oscar = new("Oscar", "Labrador");
//var (who, what) = oscar;
//WriteLine($"{who} is a {what}");

#endregion Positional data members in records

#region Defining a primary constructor for a class

Headset vp = new("Apple", "Vesion Pro");
WriteLine($"The {vp.productName} is made by {vp.manufacture}");

Headset holo = new();
WriteLine($"The {holo.productName} is made by {holo.manufacture}");

Headset mq = new() { manufacture = "Meta", productName = "Quest 3" };
WriteLine($"The {mq.productName} is made by {mq.manufacture}");

#endregion Defining a primary constructor for a class