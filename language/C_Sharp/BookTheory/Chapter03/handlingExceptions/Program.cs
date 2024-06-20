using System.Linq.Expressions;

WriteLine("Hello, Exception!");
WriteLine();

#region Wrapping error-prone code in a try block

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();

//if (input == null)
//{
//    WriteLine("You did not enter a value so the app has ended");
//    return;
//}

try
{
    int age = int.Parse(input!);
    WriteLine($"You are {age} year old.");
}
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}

WriteLine("After parsing");

#endregion Wrapping error-prone code in a try block

WriteLine();

#region Catching with filters

Write("Enter an amount: ");
string amount = ReadLine()!;

if (string.IsNullOrEmpty(amount)) return;

try
{
    decimal amountValue = decimal.Parse(amount);
    WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains("$"))
{
    WriteLine("Amounts cannot use the dollor sign!");
}
catch (FormatException)
{
    WriteLine("Amounts must only contain digits!");
}

#endregion Catching with filters

WriteLine();

#region Throwing overflow exception with the checked statement

try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial Value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    }
}
catch (OverflowException)
{
    WriteLine("The code overflowed but I caught the exception.");
}

#endregion Throwing overflow exception with the checked statement

WriteLine("");

#region Disabling compiler over flow checks with unchecked statement

unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}

#endregion Disabling compiler over flow checks with unchecked statement