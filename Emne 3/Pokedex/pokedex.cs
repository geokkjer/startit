namespace Pokedex;

public class Pokemon
{
    internal int Health;
    internal int Level;
    internal string Name;

    public Pokemon(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }
}