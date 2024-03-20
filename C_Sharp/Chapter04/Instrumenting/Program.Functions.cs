using System.Diagnostics;
using System.Runtime.CompilerServices;

internal partial class Program
{
    private static void LogSourceDetail(
        bool condition,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string filepath = "",
        [CallerLineNumber] int line = 0,
        [CallerArgumentExpression(nameof(condition))] string expression = "")
    {
        Trace.WriteLine(string.Format(
            "[{0}]\n {1} on line {2}. Expression: {3}", filepath, memberName, line, expression));
    }
}