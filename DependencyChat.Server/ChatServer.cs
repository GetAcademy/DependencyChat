namespace DependencyChat.Server
{
    public class ChatServer
    {
        private readonly List<IMessageReceiver> _clients;

        public ChatServer()
        {
            _clients = new List<IMessageReceiver>();
        }

        public void Register(IMessageReceiver chatClient)
        {
            _clients.Add(chatClient);
        }

        public void SendMessage(string message)
        {
            foreach (var chatClient in _clients)
            {
                chatClient.ReceiveMessage(message);
            }
        }
    }
}
