// See https://aka.ms/new-console-template for more information
//#error version

//WriteLine("Hello, World!");
//WriteLine($"Computer Name: {Env.MachineName}");

using System.Reflection; // To use Assembly, TypeName, and so on.

// Declare some unused variable using types in
// additional assemblies to make them load too.
System.Data.DataSet ds = new();
HttpClient client = new();

// Get the entry assembly that is the entry point for this app.
Assembly? myapp = Assembly.GetEntryAssembly();

// If the previous statement returned nothing then end the app.
if (myapp is null) return;

// Loop through the assemblies that my app references.
foreach (AssemblyName name in myapp.GetReferencedAssemblies())
{
    // Load the assembly so that we can read its details.
    Assembly a = Assembly.Load(name);

    //Declare a variablee to count the number of methods.
    int methodCount = 0;

    // Loop through the types in the assembly.
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // Add up the counts of methods.
        methodCount += t.GetMethods().Length;
    }

    // Output the count of types and their methods.
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
               arg0: a.DefinedTypes.Count(),
                      arg1: methodCount,
                             arg2: name.Name);
}