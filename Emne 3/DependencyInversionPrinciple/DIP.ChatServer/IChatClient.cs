namespace DIP.ChatServer;

public interface IChatClient
{
   void Receive(string message); 
}