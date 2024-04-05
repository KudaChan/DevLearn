using System.Globalization;

internal partial class Program
{
    private static void ConfigureConsole(
        string culcute = "en-in",
        bool useComputerCulture = false,
        bool showCulture = true)
    {
        OutputEncoding = System.Text.Encoding.UTF8;

        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culcute);
        }

        if (showCulture)
        {
            WriteLine($"Current culture: {CultureInfo.CurrentCulture.DisplayName}.");
        }
    }
}