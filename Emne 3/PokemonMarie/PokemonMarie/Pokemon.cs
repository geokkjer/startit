namespace PokemonMarie;

internal class Pokemon
{
    public int Level { get; private set; }
    public string Type { get; private set; }
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Strength { get; private set; }

    public Pokemon(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public void Fight(Pokemon opponent)
    {
        opponent.LooseHealth(Strength); 
    }

    public void LooseHealth(int strength)
    {
        Health -= strength;
    }
}