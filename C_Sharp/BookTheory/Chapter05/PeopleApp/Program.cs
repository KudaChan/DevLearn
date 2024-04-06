using Packt.Shared;

ConfigureConsole();

Person bob = new();
bob.Name = "Bob Smith";

bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 7, minute: 30, second: 0,
    offset: TimeSpan.FromHours(-5));

WriteLine(
       format: "{0} was born on {1:dddd, d MMMM, yyyy} at {1:hh:mm tt}",
          arg0: bob.Name, arg1: bob.Born);

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
    TimeSpan.Zero)
};

WriteLine(format: "{0} was born on {1:d}.",
    arg0: alice.Name, arg1: alice.Born);

Person chandan = new()
{
    Name = "Chandan Kumar",
    Born = new DateTimeOffset(
        year: 2002, month: 07, day: 05,
        hour: 9, minute: 15, second: 0,
        offset: TimeSpan.FromHours(+5)),
    //FavoriteAncientWonder = WorndersOfTheAncientWorld.GreatPyramidOfGiza
    BucketList = WorndersOfTheAncientWorld.GreatPyramidOfGiza | WorndersOfTheAncientWorld.HangingGardensOfBabylon
};

WriteLine("");

WriteLine(
    format: "{0} was born on {1:dddd, d MMMM, yyyy} at {1:hh:mm tt}. His bucketlist to visit is {2}",
    arg0: chandan.Name,
    arg1: chandan.Born,
    arg2: chandan.BucketList);