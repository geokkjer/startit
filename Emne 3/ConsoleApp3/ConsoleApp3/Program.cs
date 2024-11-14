namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static decimal sum()
        { 
            int a = 3;
            decimal b = 5;
            decimal sum = a + b;
            return sum;

        }
        private static decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }

        private static void ReturnNothing()
        {
            Console.WriteLine("Denne metoden returnerer ingenting");
        }

        public static void Run()
        {
            Console.WriteLine(sum());
            Console.WriteLine($"Summen av 9 og 5 er: {Sum(9,5)}");
            ReturnNothing();
        }
    }
}