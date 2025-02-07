﻿#region Storing Number

// An unsigned integer is a positive whole number or 0
using System;

uint naturalNumber = 23;

// AN integer is a negative or positive whole number or 0
int integerNumber = -23;

// A float is a single-precision floating-point number.
// The F and f suffix makes the value a float literal.
// The suffix is required to compile.
float realNumber = 2.3f;

// A double is a double-precision floating-point number.
// double is the default for a number value with a decimal point.
double anotherRealNumber = 2.3;

Console.WriteLine($"Nautal number = {naturalNumber}");
Console.WriteLine($"Integer Number = {integerNumber}");
Console.WriteLine($"Real Number = {realNumber}");
Console.WriteLine($"Another Real Number (using decimal) = {anotherRealNumber}");

#endregion

Console.WriteLine("\n");

#region Exploring whole numbers

int decimalNotation = 2_000_000;
int binaryNotation = 0b_001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// Check the three variables have the same value
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

// Output the variable values in decimal.
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}");

// Output the variable value
Console.WriteLine($"{decimalNotation:D}");
Console.WriteLine($"{binaryNotation:B}");
Console.WriteLine($"{hexadecimalNotation:X}");

#endregion

Console.WriteLine("\n");

#region Exploring number sizes

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range{double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

#endregion

Console.WriteLine("\n");

#region Comparing Doouble and decimal Types

Console.WriteLine("Using Doubles:");
double a = 0.1;
double b = 0.2;

if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine("\n");

Console.WriteLine("Using Float:");
float c = 0.1F;
float d = 0.2F;

if (c + d == 0.3F)
{
    Console.WriteLine($"{a} + {b} equals {0.3F}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3F}");
}

Console.WriteLine("\n");

Console.WriteLine("Using Decimal:");
decimal e = 0.1M;
decimal f = 0.2M;

if (e + f == 0.3M)
{
    Console.WriteLine($"{a} + {b} equals {0.3M}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3M}");
}

Console.WriteLine("\n");

#endregion

Console.WriteLine("\n");

#region New Number types and unsafe code

unsafe
{
    Console.WriteLine($"Half uses {sizeof(Half)} bytes and can storenumbers in the range {Half.MinValue:N0}to {Half.MaxValue:N0}.");
    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
}

#endregion