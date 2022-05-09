namespace DependencyChat.DependencyInjection
{
    internal class LetterCountingService
    {
        private readonly ITextFetcher _textFetcher;

        public LetterCountingService(ITextFetcher textFetcher)
        {
            _textFetcher = textFetcher;
        }

        public int Count(char letter)
        {
            var count = 0;
            //using var sr = new StreamReader("TextFile1.txt");
            
            //var line = sr.ReadLine();
            var line = _textFetcher.GetLine();
            while (line != null)
            {
                count += line.Count(c => c == letter);
                //line = sr.ReadLine();
                line = _textFetcher.GetLine();
            }
            return count;
        }
    }
}
