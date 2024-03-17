using static System.Console;

internal partial class Program
{
    private static void WhatsMyNamespace()
    {
        WriteLine("Namespace of Program class: {0}",
            arg0: typeof(Program).Namespace ?? "null");
    }
}