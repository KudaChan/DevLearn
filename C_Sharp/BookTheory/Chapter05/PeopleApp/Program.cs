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