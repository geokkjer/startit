using System;
namespace Pokedex
{
    // 1/3 Planning 
    // 1/6 Coding
    // 1/4 component test and early system test
    // 1/4 system test, all components in hand
    // - "The Mythical Man Month" by Frederick P. Brooks
    
    class Program
    {
        static void Main(string[] args)
        {
            var pikachu = new Pokemon("Pikachu", 10, 30);
            Console.WriteLine($"{pikachu.Name} har {pikachu.Health} hp og er level {pikachu.Level}");
            
            var bulbasaur = new Pokemon("Bulbasaur",20, 90);
            Console.WriteLine($"{bulbasaur.Name} har {bulbasaur.Health} hp og er level {bulbasaur.Level}");
        }
    }
}

