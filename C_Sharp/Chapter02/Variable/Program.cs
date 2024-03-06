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