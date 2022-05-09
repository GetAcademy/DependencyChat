namespace DependencyChat.DependencyInjection
{
    internal class ConsoleTextFetcher : ITextFetcher
    {
        public string GetLine()
        {
            Console.Write("Skriv noe: ");
            var line = Console.ReadLine();
            return line.Length == 0 ? null : line;
        }
    }
}
