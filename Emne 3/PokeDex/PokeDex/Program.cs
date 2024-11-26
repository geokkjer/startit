namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pikachu = new Pokemon( "Pikachu", 12, 22);
            Pokemon noname = new Pokemon( "NoName");
            Pokemon nothing = new Pokemon();
            
            Console.WriteLine($"Navn: {pikachu.Name}\nHelse: {pikachu.Health}\nNivå: {pikachu.Level}");
            Console.WriteLine($"Navn: {noname.Name}\nHelse: {noname.Health}\nNivå: {noname.Level}");
             Console.WriteLine($"Navn: {nothing.Name}\nHelse: {nothing.Health}\nNivå: {nothing.Level}");
        }
    } 
}

