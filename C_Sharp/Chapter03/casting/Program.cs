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