using System.Net;

namespace DependencyChat.DependencyInjection
{
    internal class WebTextFetcher : ITextFetcher
    {
        private readonly StreamReader _reader;

        public WebTextFetcher()
        {
            var webRequest = WebRequest.Create("https://www.vg.no");

            var response = webRequest.GetResponse();
            var content = response.GetResponseStream();
            _reader = new StreamReader(content);
        }
        public string GetLine()
        {
            return _reader.ReadLine();
        }
    }
}
