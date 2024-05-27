void DisplayRandomNumbers()
{
    Random random = new Random();
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(random.Next(1, 100));
    }
}

Console.WriteLine("Generating random number: ");
DisplayRandomNumbers();