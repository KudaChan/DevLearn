#region Fromatting using numbered ppositional arguments

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
    );

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

Console.WriteLine(formatted);

// Three parameter values can use named arguments.
Console.WriteLine("{0} {1} lived in {2}", arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

// Four or more parameter values cannot use named arguments.
Console.WriteLine(
    "{0} {1} lives in {2} and worked in the {3} team at {4}.",
    "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

// Formating using string interpolation
Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

#endregion

Console.WriteLine("\n");