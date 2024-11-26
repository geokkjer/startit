namespace Pokedex;

 internal class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public Pokemon(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }

        public Pokemon(string name)
        {
            Name = name;
        }

        public Pokemon()
        {
        }
    }