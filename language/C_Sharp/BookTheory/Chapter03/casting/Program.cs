using System.Globalization;
using static System.Convert;

WriteLine("Hello, Casting!");
WriteLine("");

#region casting implicitly and explicitly

int a = 10;
double b = a;
WriteLine($"a is {a}, b is {b}");

WriteLine("");

double c = 9.8;
int d = (int)c;
WriteLine($"c is {c}, d is {d}");

WriteLine("");

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

#endregion casting implicitly and explicitly

WriteLine("");

#region Negative numbers representation in binary

WriteLine("{0,12} {1, 34}", "Decimal", "Binary");
WriteLine("{0,12} {0,34:B32}", int.MaxValue);
for (int i = 8; i > -8; i--)
{
    WriteLine("{0,12} {0,34:B32}", i);
}
WriteLine("{0,12} {0,34:B32}", int.MinValue);

#endregion Negative numbers representation in binary

WriteLine("");

#region Convrting with the System.Convert type

double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g}, h is {h}");

#endregion Convrting with the System.Convert type

WriteLine("");

#region Rounding numbers and the default rounding rules

double[,] doubles =
{
    { 9.49, 9.5, 9.51 },
    { 10.49, 10.5, 10.51 },
    { 11.49, 11.5, 11.51 },
    { 12.49, 12.5, 12.51 },
    { -12.49, -12.5, -12.51 },
    { -9.49, -9.5, -9.51 },
    { -10.49, -10.5, -10.51 },
    { -11.49, -11.5, -11.51 }
};

WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Write($"| {doubles[x, y],6} | {ToInt32(doubles[x, y]),7}");
    }
    WriteLine("|");
}
WriteLine();

#endregion Rounding numbers and the default rounding rules

WriteLine();

#region Taking control of rounding rules

foreach (double n in doubles)
{
    WriteLine(format:
        "Math.Round({0}, 0, MidpointRounding. AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
}

#endregion Taking control of rounding rules

WriteLine();

#region Converting from any type to a string

int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());

#endregion Converting from any type to a string

WriteLine();

#region Converting from a binary object to a string

byte[] binaryObject = new byte[128];

Random.Shared.NextBytes(binaryObject);

WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X2} ");
}
WriteLine();

string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");

#endregion Converting from a binary object to a string

WriteLine();

#region Parsing from strings to numbers or dates and times;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("4 June 1980");
WriteLine($"I have {friends} friends to invite to my party.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

#endregion Parsing from strings to numbers or dates and times;

WriteLine();

#region Avoiding Parse exception by using the TryParse method

Write("How many eggs are there? ");
string? input = ReadLine();

if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}

#endregion Avoiding Parse exception by using the TryParse method