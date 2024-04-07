namespace Packt.Shared;

public class Person : Object
{
    #region Fields: Data or state for the person.

    public string? Name;
    public DateTimeOffset Born;

    //public WorndersOfTheAncientWorld FavoriteAncientWonder;
    public WorndersOfTheAncientWorld BucketList;

    public List<Person> Friends = new();

    public const string Species = "Homo Sapiens";

    public readonly string HomePlanet = "Earth";

    public readonly DateTime Instantiated;

    #endregion Fields: Data or state for the person.

    #region Constructors: Called when using new to instantiate a type.

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    #endregion Constructors: Called when using new to instantiate a type.
}