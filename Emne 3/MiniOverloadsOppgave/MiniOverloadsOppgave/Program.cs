namespace MiniOverloadsOppgave
{
    class Welcome
    {
        void PrintWelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen!");
        }

        void PrintWelcomeMessage(string kompliment = "Du er Snill")
        {
            Console.WriteLine($"Hei og velkommen! {kompliment}");    
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            = PrintWelcomeMessage();
            PrintWelcomeMessage("Du er nokså snill");
        }
        
    }
}
