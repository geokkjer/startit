namespace PokemonMarie;

internal class Trainer
{
    public PokemonWorld MyWorld { get; private set; }
    public List<string> Inventory { get; private set; } 
    public Pokemon StartPokemon { get; private set; }
    public string Name { get; private set; }

    public Trainer(PokemonWorld myWorld, List<string> inventory, Pokemon startPokemon, string name)
    {
        MyWorld = myWorld;
        Inventory = new List<string>();
        StartPokemon = new Pokemon(11,"Pikachu", "Lightning",100,100);
        Name = name;
    }

    public Pokemon GoToWilderness()
    {
        while (true)
        {
            Console.WriteLine("Where do you want to go?");
            Console.WriteLine("1. Water");
            Console.WriteLine("2. Grass");
            Console.WriteLine("3. Mud");
            var input = Console.ReadLine();

            if (input == "1")
            {
                return MyWorld.GetRandomPokemon("Water");
            } else if (input == "2")
            {
                return MyWorld.GetRandomPokemon("Grass");
            }
            else
            {
                return MyWorld.GetRandomPokemon("Mud");
            }
        }
    }

    public void GoToGym()
    {
        
    }

    public void BattlePokemon(Pokemon pokemonToFight)
    {
        while (pokemonToFight.Health > 0)
        {
            
        }
    }

    public void CatchPokemon(Pokemon pokemonToCatch)
    {
        
    }
    public void EnterStore()
    {

    }
    public void BuyItem(string itemType)
    {

    }
}