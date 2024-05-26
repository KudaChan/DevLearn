using System;
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("in-IN");

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine("As a valuable customer of our Magic Yield product, we are excited to inform you of a new financial product that would be of interest to you.");
Console.WriteLine();
Console.WriteLine($"Currently you own {currentShares:N2} shares at a return of {currentReturn:p2}.");
Console.WriteLine();
Console.WriteLine("Here's a quick comparison:\n");
string comparisonMessage = "";
comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(10);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(10);

Console.WriteLine(comparisonMessage);