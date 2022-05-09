using DependencyChat.Server;

namespace DependencyChat
{
    internal class ChatClient : IMessageReceiver
    {
        private readonly ChatServer _server;
        private readonly string _name;

        public ChatClient(ChatServer server, string name)
        {
            _name = name;
            _server = server;
            server.Register(this);
        }

        public void SendMessage(string message)
        {
            _server.SendMessage($"{_name}> {message}");
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{_name} mottok: \n    {message}");
        }
    }
}
