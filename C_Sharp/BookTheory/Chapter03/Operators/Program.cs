WriteLine("Hello, Oherators!");
WriteLine("");

#region Exhloring unary oherators

int a = 3;
int b = a++;

WriteLine($"a: {a}, b: {b}");

WriteLine("");

int c = 3;
int d = ++c;

WriteLine($"c: {c}, d: {d}");

#endregion Exhloring unary oherators

WriteLine("");

#region binary arithmetic oherators

int e = 11;
int f = 3;

WriteLine($"e: {e}, f: {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

WriteLine("");

double g = 11.0;

WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

#endregion binary arithmetic oherators

WriteLine("");

#region Assignment Oherators

int h = 6;

h += 3;
WriteLine($"h += 3: {h}");
h -= 3;
WriteLine($"h -= 3: {h}");
h *= 3;
WriteLine($"h *= 3: {h}");
h /= 3;
WriteLine($"h /= 3: {h}");

#endregion Assignment Oherators

WriteLine("");

#region Null Coalescing Oherator

WriteLine("Enter your name: ");
string? name = ReadLine();

int maxLength = name?.Length ?? 0;

name ??= "unknown";

WriteLine($"Name: {name}, Max Length: {maxLength}");

#endregion Null Coalescing Oherator

WriteLine("");

#region Exhloring logical oherators

bool i = true;
bool j = false;

WriteLine($"AND     | i     | j     ");
WriteLine($"i       | {i & i,-5} | {i & j,-5}   ");
WriteLine($"j       | {j & i,-5} | {j & j,-5}   ");
WriteLine("");
WriteLine($"OR      | i     | j     ");
WriteLine($"i       | {i | i,-5} | {i | j,-5}   ");
WriteLine($"j       | {j | i,-5} | {j | j,-5}   ");
WriteLine("");
WriteLine($"XOR     | i     | j     ");
WriteLine($"i       | {i ^ i,-5} | {i ^ j,-5}   ");
WriteLine($"j       | {j ^ i,-5} | {j ^ j,-5}   ");

#endregion Exhloring logical oherators

WriteLine("");

#region Exploring conditional logical oherators

static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;
}

WriteLine($"p & DoStuff() = {i & DoStuff()}");
WriteLine($"j & DoStuff() = {j & DoStuff()}");

WriteLine();

WriteLine($"p && DoStuff() = {i && DoStuff()}");
WriteLine($"j && DoStuff() = {j && DoStuff()}");

#endregion Exploring conditional logical oherators

WriteLine("");

#region Exploring bitwise and binary shift operators

int k = 10;
int l = 6;

WriteLine($"Expression | Decimal | Binary");
WriteLine($"-------------------------------");
WriteLine($"k          | {k,7} | {k:B8}");
WriteLine($"l          | {l,7} | {l:B8}");
WriteLine($"-------------------------------");
WriteLine($"k & l      | {k & l,7} | {k & l:B8}");
WriteLine($"k | l      | {k | l,7} | {k | l:B8}");
WriteLine($"k ^ l      | {k ^ l,7} | {k ^ l:B8}");
WriteLine($"-------------------------------");
WriteLine($"k << 3     | {k << 3,7} | {(k << 3):B8}");
WriteLine($"k * 8      | {k * 8,7} | {(k * 8):B8}");
WriteLine($"k >> 3     | {k >> 3,7} | {(k >> 3):B8}");

#endregion Exploring bitwise and binary shift operators

WriteLine("");

#region Miscellaneous operators

int age = 50;
WriteLine($"The {nameof(age)} variable uses {sizeof(int)} bytes of memory.");

#endregion Miscellaneous operators