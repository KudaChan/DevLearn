using System.Diagnostics;
using Microsoft.Extensions.Configuration;

WriteLine("Hello, Instrumenting!");
WriteLine("");

string logPath = Path.Combine(Environment.CurrentDirectory, "log.txt");
WriteLine($"Writing to {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

#if DEBUG

Trace.AutoFlush = true;

#endif

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");

string settingsFile = "appsettings.json";

string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);

WriteLine($"Processing: {0}", settingsPath);

WriteLine("--{0} contents--", settingsFile);
WriteLine(File.ReadAllText(settingsPath));
WriteLine("----");

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory());

// Add the setting file to the processed configuration and make it
// mandatory so an exception will be thrown if the file is missing.
builder.AddJsonFile(settingsFile, optional: false, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
    displayName: "PacktSwitch",
    description: "This switch is set via the JSON configuration file");

configuration.GetSection("PacktSwitch").Bind(ts);

WriteLine($"Trace switch value: {ts.Value}");
WriteLine($"Trace switch value: {ts.Level}");

Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace info");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");

int unitsInStock = 12;
LogSourceDetail(unitsInStock > 10);

Debug.Close();
Trace.Close();

WriteLine("Press enter to exit.");
ReadLine();