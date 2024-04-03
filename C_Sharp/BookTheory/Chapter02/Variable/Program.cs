using System.Xml; // TO use XmlDocument.

internal class Program
{
    private static void Main(string[] args)
    {
        #region General varialbles

        Console.WriteLine("Hello, Variable!");
        Console.WriteLine("This is the Variable representation of the Hello World program.");

        // Let the heightInMeter variable become equal to the value 1.88
        double heightInMenter = 1.88;
        // Using nameof function to get the name of the variable
        Console.WriteLine($"The variable{nameof(heightInMenter)} has the value {heightInMenter}");

        Console.WriteLine("\n");

        // Character demonstration
        Console.WriteLine("Character demonstration");
        char letter = 'A';
        char digit = '1';
        char symbol = '$';
        Console.WriteLine($"The letter is {letter}");
        Console.WriteLine($"The digit is {digit}");
        Console.WriteLine($"The symbol is {symbol}");

        Console.WriteLine("\n");

        // String demonstration
        Console.WriteLine("String demonstration");
        string firstName = "John";
        string lastName = "Doe";
        string phoneNumber = "123-456-7890";

        // Assiging a string returned from the string class constructor.
        string horizontalLine = new string('-', 40); // 40 hypens.

        //Assigning an emoji by converting from unicode
        string grinningEmpji = char.ConvertFromUtf32(0x1F600);

        Console.WriteLine($"{horizontalLine}");
        Console.WriteLine($"{nameof(firstName)} - {firstName}");
        Console.WriteLine($"{nameof(lastName)} - {lastName}");
        Console.WriteLine($"{nameof(phoneNumber)} - {phoneNumber}");
        Console.WriteLine($"{nameof(grinningEmpji)} - {grinningEmpji}");

        Console.WriteLine("\n");

        // Verbatim string demonstration
        Console.WriteLine("Verbatim string demonstration");
        string filePath = "C:\\Program Files\\Microsoft\\";
        string filePathVerbatim = @"C:\Program Files\Microsoft\";
        Console.WriteLine($"{nameof(filePath)} - {filePath}");
        Console.WriteLine($"{nameof(filePathVerbatim)} - {filePathVerbatim}");

        Console.WriteLine("\n");

        // Raw string literal demonstration
        Console.WriteLine("Raw string literal demonstration");
        string xml = """
            <person age="50">
                <first_name>Mark</first_name>
            </person>
""";
        Console.WriteLine($"{nameof(xml)} \n {xml}");

        Console.WriteLine("\n");

        // Raw interpolation string literals demonstration
        Console.WriteLine("Raw interpolation String Literal Demonstration.");
        var person = new { FirstName = "Alice", Age = 56 };
        string json = $$"""
                "first_name" : "{{person.FirstName}}",
                "age" : {{person.Age}};
                "Calculation" : "{{{1 + 2}}}"
    """;

        Console.WriteLine("Row interpolation stringliteral \"json\"");
        Console.WriteLine(json);

        #endregion General varialbles

        Console.WriteLine("\n");

        #region Storing any type of objects

        object height = 1.88; // storing a double in an object
        object name = "Amir"; // storing a string in an object
        Console.WriteLine($"{name} is {height} meters tall");

        //int length1 = name.Length; // gives compile error!
        int length = ((string)name).Length; // cast to access members
        Console.WriteLine($"{name} has {length} characters.");

        #endregion Storing any type of objects

        Console.WriteLine("\n");

        #region Stroing dynamic types

        dynamic something;

        // Storing an array of int values in a dynamic object.
        // An array of any type has a Length property.
        something = new int[] { 1, 2, 3, 4, 5 };

        // Output the type of something variable.
        Console.WriteLine($"The length of something is {something.Length}");
        Console.WriteLine($"something is a {something.GetType()}");

        // Storing an int in a dynamic object.
        // int does not have a Length property.
        something = 1;

        // Output the type of something variable.
        Console.WriteLine($"The length of something is {something.Length}");
        Console.WriteLine($"something is a {something.GetType()}");

        // Storing a string in a dynamic object.
        // String has a Length property.
        something = "Hello, World!";

        // Output the type of something variable.
        Console.WriteLine($"The length of something is {something.Length}");
        Console.WriteLine($"something is a {something.GetType()}");

        #endregion Stroing dynamic types

        Console.WriteLine("\n");

        #region Stroing local variables

        int population = 66_000_000; // 66 million in UK
        double weight = 1.88; // in Kg
        decimal price = 4.99M; // in pounds sterling
        string fruit = "Apples"; // strings use double-quotes
        char letterNew = 'A'; // chars use single-quotes
        bool happy = true; // Booleans have value of true or false

        Console.WriteLine($"The UK population is about {population}");
        Console.WriteLine($"The weight of an {fruit} is about {weight} kg");
        Console.WriteLine($"The price of {fruit} is about {price:C}");
        Console.WriteLine($"The first letter in {fruit} is {letterNew}");
        Console.WriteLine($"Are you {happy}?");

        #endregion Stroing local variables

        Console.WriteLine("\n");

        #region Storing variable using var

        var populationVar = 66_000_000; // 66 million in UK
        var weightVar = 1.88; // in Kg
        var priceVar = 4.99M; // in pounds sterling
        var fruitVar = "Apples"; // strings use double-quotes
        var letterVar = 'A'; // chars use single-quotes
        var happyVar = true; // Booleans have value of true or false

        Console.WriteLine($"The UK population is about {populationVar}");
        Console.WriteLine($"The weight of an {fruitVar} is about {weightVar} kg");
        Console.WriteLine($"The price of {fruitVar} is about {priceVar:C}");
        Console.WriteLine($"The first letter in {fruitVar} is {letterVar}");
        Console.WriteLine($"Are you {happyVar}?");

        #endregion Storing variable using var

        Console.WriteLine("\n");

        #region Inferring the type of a local variable

        // Good use of var because it avooids the repeated type
        // as shown in the more verbose second statement.
        var xml1 = new XmlDocument();
        XmlDocument xml2 = new XmlDocument();

        // Bad use of var because we cannot tell the type, so we
        // should use a specific type decelaraction as shown in
        // the second statement.
        var file1 = File.CreateText("something1.txt");
        StreamWriter file2 = File.CreateText("something2.txt");

        #endregion Inferring the type of a local variable

        Console.WriteLine("\n");

        #region Getting and setting the default values for types

        Console.WriteLine($"default(int) = {default(int)}");
        Console.WriteLine($"default(bool) = {default(bool)}");
        Console.WriteLine($"default(DateTime) = {default(DateTime)}");
        Console.WriteLine($"default(string) = {default(string)}");

        int number = 13;
        Console.WriteLine($"number = {number}");
        number = default;
        Console.WriteLine($"number = {number}");

        #endregion Getting and setting the default values for types
    }
}