#region Branching with the if Statement

string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 chars.");
}
else
{
    WriteLine("Your password is strong.");
}

#endregion

#region Pattern matching with the if statement.

object o = "3";
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply");
}

#endregion

#region Branching with the switch statement.

int number = Random.Shared.Next(minValue: 1, maxValue: 7);
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break;

    case 2:
        WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}
WriteLine("After end of Switch.");
A_label:
WriteLine($"After A_label");

#endregion

#region Pattern matching with the switch statement

var animals = new Animal?[]
{
    new Cat { Name = "Karen", Born = new(year: 2022, month: 8, day: 23), Legs = 4, IsDomestic = true},
    null,
    new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12) },
    new Spider { Name = "Sid Vicious", Born = DateTime.Today, IsPoisonous = true },
    new Spider { Name = "Captain Furry", Born = DateTime.Today }
};

foreach (Animal? animal in animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"The cat named {fourLeggedCat.Name} has 4 legs.";
            break;

        case Cat WildCat when WildCat.IsDomestic == false:
            message = $"The cat named {WildCat.Name} is wild.";
            break;

        case Cat cat:
            message = $"The cat named is {cat.Name}.";
            break;

        case Spider spider when spider.IsPoisonous:
            message = $"{spider.Name} is a poisonous spider.";
            break;

        case null:
            message = "There is no animal to identify";
            break;

        default:
            message = $"{animal.Name} is a {animal.GetType().Name}.";
            break;
    }
    WriteLine($"Switch statement: {message}");

    message = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4 => $"The cat named {fourLeggedCat.Name} has 4 legs.",
        Cat WildCat when WildCat.IsDomestic == false => $"The cat named {WildCat.Name} is wild.",
        Cat cat => $"The cat named is {cat.Name}.",
        Spider spider when spider.IsPoisonous => $"{spider.Name} is a poisonous spider.",
        null => "There is no animal to identify",
        _ => $"{animal.Name} is a {animal.GetType().Name}."
    };
    WriteLine($"switch expression: {message}");
}

#endregion