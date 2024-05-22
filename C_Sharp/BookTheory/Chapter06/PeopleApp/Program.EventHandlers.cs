using Packt.Shared;

internal partial class Program
{
    private static void Harry_Shout(object? sender, EventArgs e)
    {
        if (sender is null) return;

        if (sender is not Person p) return;

        WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
    }

    private static void Harry_Shout2(object? sender, EventArgs e)
    {
        WriteLine("Stop it");
    }
}