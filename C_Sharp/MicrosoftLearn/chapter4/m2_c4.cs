string[] values = { "12.3", "45", "ABC", "11", "DEF" };

float intResult = 0;
float total = 0;
string completeMessage;
foreach (var value in values)
{
    if (float.TryParse(value, out intResult))
    {
        total += intResult;
    }
    else
    {
        completeMessage += value;
    }
}

Console.WriteLine($"String: {completeMessage}");
Console.WriteLine($"Total: {total}");