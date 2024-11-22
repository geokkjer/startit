namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var pikachu = new Pikachu();
            Console.WriteLine($"Pikachu har {Pikachu.Health}hp og er level {Pikachu.Level}");
        }
    }
}

