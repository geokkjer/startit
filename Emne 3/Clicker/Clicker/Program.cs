using System.Text.Json;

namespace Clicker
{
    internal class StaticClicker
    {
        
        
        public static void Main()
        {
            var json = File.ReadAllText("test.json");
            var people = JsonSerializer.Deserialize<Person[]>(json, options);
            var clickers = new Clicker[]
            {
                new Clicker('a'),
                new Clicker('b'),
            };
            while (true)
            {
                Console.Clear();
                
                Console.WriteLine($"Klikker A: Du har {Points} poeng. a + poeng A upgrade");
                var cmdKey = Console.ReadKey(true);
                HandleCommand(cmdKey);
            }
        }

        public static void HandleCommand(cmdKey)
        {
            if (cmdKey.KeyChar == 'a')
            {
                _points += _upgrades;
            }
            else if (cmdKey.KeyChar == 'A')
            {
                if (_points >= 10)
                {
                    _upgrades++;
                    _points -= 10;
                }
            }
        }

    }
}