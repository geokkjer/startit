namespace MiniOverloads
{

    public class Message
    {
        string MessageText { get; set; }
        string Kompliment { get; set; }

        public Message(string messageText)
        {
            MessageText = messageText;
        }

        public Message(string messageText, string kompliment)
        {
            MessageText = messageText;
            Kompliment = kompliment;
            
        }

        public void PrintWelcomeMessage()
        {
            Console.WriteLine($"{MessageText} {Kompliment}");
        }
        
    }
}