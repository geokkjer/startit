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

        public static void Run()
        {
            Console.WriteLine(sum());
            Console.WriteLine(Sum(3,5));
        }
    }
}