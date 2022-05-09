namespace DependencyChat.Server
{
    public interface IMessageReceiver
    {
        void ReceiveMessage(string message);
    }
}
