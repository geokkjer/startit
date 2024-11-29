namespace StaticogIkkestatic
{
    class Program
    {
        static void Main(string[] args)
        { 
            ShowSeperatorRow();
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

