using DependencyChat.Chat;
using DependencyChat.DependencyInjection;

// ChatDemo.Run();
//var fetcher = new FileTextFetcher();
//var fetcher = new WebTextFetcher();
var fetcher = new ConsoleTextFetcher();
var counter = new LetterCountingService(fetcher);
Console.WriteLine(counter.Count('a'));