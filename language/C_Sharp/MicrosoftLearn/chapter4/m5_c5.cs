const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length;
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

const string tradeSymbol = "&trade;";
output = input.Replace(tradeSymbol, "&reg;");

const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

const string closeDiv = "</div>";
int divEnd = output.IndexOf(closeDiv);
output = output.Remove(divEnd, closeDiv.Length);


Console.WriteLine(quantity);
Console.WriteLine(output);