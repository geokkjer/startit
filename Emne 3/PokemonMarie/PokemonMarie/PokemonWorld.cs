using System.ComponentModel.Design;

namespace PokemonMarie;

internal class PokemonWorld
{
    public Trainer MyTrainer { get; set; }
    public List<Pokemon> WildPokemons { get; set; }
    Random Random { get; set; } = new Random();

    public PokemonWorld()
    {
        MyTrainer = new Trainer( "Ash", this);
        WildPokemons = new List<Pokemon>()
        {
            new Pokemon("Lucario", "Grass"), 
            new Pokemon("Bulbasaur", "Grass"),
            new Pokemon("Gyarados", "Water"),
            new Pokemon("Oshawott", "Water"),
            new Pokemon("Grimer", "Mud"),
            new Pokemon("Diglett", "Mud"),
        };
        Menu();
    }
    public void Menu()
    {
        bool appRunning = true;
        while (appRunning)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Go to the Wilderness");
            Console.WriteLine("2. Go to the store");
            Console.WriteLine("3. Go to a pokemon gym");
            Console.WriteLine("4. Exit");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WildernessMenu();
                    break;
                case "2":
                    MyTrainer.EnterStore();
                    break;
                case "3":
                    MyTrainer.GoToGym();
                    break;
                case "4":
                    appRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    public void WildernessMenu()
    {
        var foundPokemon = MyTrainer.GoToWilderness();
        Console.WriteLine("You found " + foundPokemon.Name );
        Console.WriteLine("Do you want to (f) fight or (c) catch ?");
        var input = Console.ReadLine();
        if (input.ToLower() == "f")
        {
            MyTrainer.BattlePokemon(foundPokemon);   
        }
        else
        {
            MyTrainer.CatchPokemon(foundPokemon);
        }
    }

    public Pokemon GetRandomPokemon(string type)
    {
        var pokemon = WildPokemons.Where(pokemon => pokemon.Type == type).ToList();
        var randomIndex = Random.Next(0, pokemon.Count);
        return pokemon[randomIndex];
    }
}