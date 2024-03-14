WriteLine("Hello, Array!");
WriteLine("");

#region working with single- dimensional arrays

string[] names;

names = new string[4];

names[0] = "Ewa";
names[1] = "Zosia";
names[2] = "Kasia";
names[3] = "Basia";

for (int i = 0; i < names.Length; i++)
{
    WriteLine($"{names[i]} is at position {i} and have length {names[i].Length}");
}

#endregion working with single- dimensional arrays

WriteLine("");

#region working with single- dimensional arrays

string[,] grid1 =
{
    { "Alpha", "Beta", "Gamma", "Delta" },
    { "Epsilon", "Zeta", "Eta", "Theta" },
    { "Anne", "Ben", "Charli", "Doug" }
};
WriteLine($"1st dimension, lower bounds: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bounds: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bounds: {grid1.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bounds: {grid1.GetUpperBound(1)}");

WriteLine("");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int column = 0; column <= grid1.GetUpperBound(1); column++)
    {
        WriteLine($"(Row {row}, Column {column}): {grid1[row, column]}");
    }
}

#endregion working with single- dimensional arrays

WriteLine("");

#region working with jagged arrays

string[][] jaggedArray =
{
    new[] { "Anne", "Ben", "Charli", "Doug" },
    new[] { "Ewa", "Zosia" },
    new[] { "Alpha", "Beta", "Gamma" }
};

for (int row = 0; row <= jaggedArray.GetUpperBound(0); row++)
{
    for (int col = 0; col <= jaggedArray[row].GetUpperBound(0); col++)
    {
        WriteLine($"Row {row}, Col {col}: {jaggedArray[row][col]}");
    }
}

#endregion working with jagged arrays

WriteLine("");

#region list pattern matching with arrays

int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] oneTwoNumbers = { 1, 2 };
int[] oneTwoTenNumbers = { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] emptyNumbers = { }; // Or use Array.Empty<int>()
int[] threeNumbers = { 9, 7, 5 };
int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };

WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
[] => "Empty array",
[1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
[1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
[1, 2] => "Contains 1 then 2.",
[int item1, int item2, int item3] => $"Contains {item1} then {item2} then {item3}.",
[0, _] => "Starts with 0, then one other number.",
[0, ..] => "Starts with 0, then any range of numbers.",
[2, .. int[] others] => $"Starts with 2, then {others.Length} morenumbers.",
[..] => "Any items in any order.",
};

#endregion list pattern matching with arrays