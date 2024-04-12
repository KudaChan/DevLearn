namespace Packt.Shared;

public partial class Person
{
    #region Properties: Methods to get/or set data or state.

    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}.",
                               arg0: Name, arg1: HomePlanet);
        }
    }

    public string Greeting => $"{Name} says 'Hello!'.";

    public int Age => DateTime.Today.Year - Born.Year;

    #endregion Properties: Methods to get/or set data or state.

    #region Defining settable properties

    public string? FavoriteIceCream { get; set; }

    private string? _favouritePrimaryColor;

    public string? FavoutitePrimaryColor
    {
        get
        {
            return _favouritePrimaryColor;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    _favouritePrimaryColor = value;
                    break;

                default:
                    throw new System.ArgumentException($"{value} is not a primary color. Choose from: red, green, blue.");
            }
        }
    }

    #endregion Defining settable properties
}