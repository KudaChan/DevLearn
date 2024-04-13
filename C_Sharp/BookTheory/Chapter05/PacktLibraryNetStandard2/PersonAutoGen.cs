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

    #region Limiting flags enum values

    private WorndersOfTheAncientWorld _favoriteAncientWonder;

    public WorndersOfTheAncientWorld FavoriteAncientWonder
    {
        get
        {
            return _favoriteAncientWonder;
        }
        set
        {
            string wonderName = value.ToString();

            if (wonderName.Contains(','))
            {
                throw new System.ArgumentException("Invalid ancient wonder.");
            }
            if (!Enum.IsDefined(typeof(WorndersOfTheAncientWorld), value))
            {
                throw new System.ArgumentException(message: "Favorite ancient wonder can only have a single enum value.",
                    paramName: nameof(FavoriteAncientWonder));
            }
            if (!Enum.IsDefined(typeof(WorndersOfTheAncientWorld), value))
            {
                throw new System.ArgumentException($"{value} is not a member of the WondersOf TheAncientWorld enum.",
                   paramName: nameof(FavoriteAncientWonder));
            }

            _favoriteAncientWonder = value;
        }
    }

    #endregion Limiting flags enum values
}