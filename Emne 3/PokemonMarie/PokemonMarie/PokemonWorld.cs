using System.ComponentModel.Design;

namespace PokemonMarie;

public class PokemonWorld
{
    public Trainer MyTrainer { get; set; }
    public Pokemon StartPokemon { get; set; }
    public List<Pokemon> WildPokemons { get; set; }

    public PokemonWorld()
    {
        MyTrainer = new Trainer("Ash");
        WildPokemons = new List<Pokemon>()
        {
            new Pokemon(), 
            new Pokemon()
        };
        Menu();
    }

    public void Menu()
    {
        Console.WriteLine("Welcome to Pokemon");   
    }
}