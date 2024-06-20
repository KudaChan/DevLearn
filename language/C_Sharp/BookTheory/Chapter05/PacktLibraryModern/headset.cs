namespace Packt.Shared;

public class Headset(string manufacture, string productName)
{
    public string manufacture { get; set; } = manufacture;
    public string productName { get; set; } = productName;

    // Default parameterless constructor calls the primary constructor
    public Headset() : this("Apple", "AirPods") { }
}