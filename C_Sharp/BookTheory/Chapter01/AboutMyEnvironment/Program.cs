namespace AboutMyEnvironment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.OSVersion.VersionString);
            Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);
        }
    }
}