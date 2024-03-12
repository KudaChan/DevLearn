internal class Animal
{
    public string? Name;
    public DateTime Born;
    public byte Legs;
}

internal class Cat : Animal
{
    public bool IsDomestic;
}

internal class Spider : Animal
{
    public bool IsPoisonous;
}