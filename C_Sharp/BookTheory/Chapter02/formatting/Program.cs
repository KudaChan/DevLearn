System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-US");

#region Fromatting using numbered ppositional arguments

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
    );

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

WriteLine(formatted);

// Three parameter values can use named arguments.
WriteLine("{0} {1} lived in {2}", arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

// Four or more parameter values cannot use named arguments.
WriteLine(
    "{0} {1} lives in {2} and worked in the {3} team at {4}.",
    "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

// Formating using string interpolation
WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

#endregion Fromatting using numbered ppositional arguments

WriteLine("\n");

#region Understanding format strings

/**
 * Syntax: {index[,alignment][:formatString]}
 */

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine();
WriteLine(format: "{0, -10} {1, 6}",
    arg0: "Name", arg1: "Count");

WriteLine(format: "{0, -10} {1, 6:N0}",
       arg0: applesText, arg1: applesCount);
WriteLine(format: "{0, -10} {1, 6:N0}",
          arg0: bananasText, arg1: bananasCount);

#endregion Understanding format strings

WriteLine("\n");

#region Custom number formatting

int number = 1234;

WriteLine(format: "{0:0000.00}", arg0: number);
WriteLine(format: "{0:####.###}", arg0: number);
WriteLine(format: "{0:00.00}", arg0: number);
WriteLine(format: "{0:0,000}", arg0: number);
WriteLine(format: "{0:%}", arg0: number);
WriteLine(format: "{0:[0];[0];Zero}", arg0: number);

WriteLine();

// Using Standard number formatting using Simpler format codes.
decimal num = 1234.5678M;

WriteLine(format: "{0:C}", arg0: num); // Currency
WriteLine(format: "{0:N}", arg0: num); // Number
WriteLine(format: "{0:E}", arg0: num); // Exponential
WriteLine(format: "{0:D}", arg0: number); // Decimal
WriteLine(format: "{0:B}", arg0: number); // Binary
WriteLine(format: "{0:X}", arg0: number); // Hexadecimal

#endregion Custom number formatting

WriteLine("\n");

#region Getting text input from the user

WriteLine("Type your first name and press Enter");
string? firstName = ReadLine();

WriteLine("Type your age and press Enter");
string age = ReadLine()!;

WriteLine($"Hello {firstName}, you look good for {age}");

#endregion Getting text input from the user

WriteLine("\n");

#region Getting key input from the user

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();

WriteLine();

WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
       arg0: key.Key,
          arg1: key.KeyChar,
             arg2: key.Modifiers);

#endregion Getting key input from the user