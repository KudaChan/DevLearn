using System.Collections;

WriteLine("Hello, iteration loops");

WriteLine("");

#region Looping with the while statement

int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

#endregion Looping with the while statement

WriteLine("");

#region Looping with the do statement

string? actualPassword = "pa$$word";
string? password;

do
{
    WriteLine("Enter your password:");
    password = ReadLine();
}
while (password != actualPassword);
{
    WriteLine("Incorrect password, try again");
}

WriteLine("Correct!");

#endregion Looping with the do statement

WriteLine("");

#region Looping with the for statement

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

for (int y = 0; y <= 10; y += 3)
{
    WriteLine(y);
}

#endregion Looping with the for statement

WriteLine("");

#region Looping with the foreach statement

string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}
WriteLine("");
IEnumerator e = names.GetEnumerator();

while (e.MoveNext())
{
    string name = (string)e.Current;
    WriteLine($"{name} has {name.Length} characters.");
}

#endregion Looping with the foreach statement