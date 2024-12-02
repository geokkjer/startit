namespace StaticogIkkestatic
{
    class Program
    {
        static void Main(string[] args)
        { 
            ShowSeperatorRow();
            var label = "Navn";
            var fieldValue = "Stavern";
            Console.WriteLine("Navn: Stavern");
            Console.WriteLine("Kommune: Larvik");
            Console.WriteLine("Fylke: Vestfold");
            ShowSeperatorRow();
        }
        static void ShowSeperatorRow()
        {
            Console.WriteLine("****************************");
        }
    }
}

