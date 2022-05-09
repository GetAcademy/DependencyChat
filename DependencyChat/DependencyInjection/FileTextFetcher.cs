namespace DependencyChat.DependencyInjection
{
    internal class FileTextFetcher : ITextFetcher
    {
        private StreamReader _sr;

        public FileTextFetcher()
        {
            _sr = new StreamReader("TextFile1.txt");
        }
        public string GetLine()
        {
            return _sr.ReadLine();
        }
    }
}
