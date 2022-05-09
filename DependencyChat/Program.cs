using DependencyChat;
using DependencyChat.Server;

var server = new ChatServer();

var client1 = new ChatClient(server, "Anders");
var client2 = new ChatClient(server, "Bertil");
var client3 = new ChatClient(server, "Cecilie");

client2.SendMessage("Hei");