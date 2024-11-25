using System;
using Pokedex;
namespace Pokemon
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
            var pikachu = new Pikachu();
            Console.WriteLine($"Pikachu har {Pikachu.Health}hp og er level {Pikachu.Level}");
        }
    }
}

