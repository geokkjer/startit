using System;

namespace GjettTallet
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int tilfeldigTall = rnd.Next(1, 100);
            bool running = true;
            var størreEllerMindre = "Du har ikke valgt et tall ennå";
            while (running == true)
            {
                Console.WriteLine($"{størreEllerMindre}");
                Console.WriteLine("Gjett ett tall mellom 1 - 100: ");
                var gjettetTallString = Console.ReadLine();
                int gjettetTall;
                int.TryParse(gjettetTallString, out gjettetTall);
                if (gjettetTall == 0)
                {
                    størreEllerMindre = "Enten 0 eller ikke ett tall";
                    Console.Clear();
                }
                else if (tilfeldigTall == gjettetTall)
                {
                    Console.WriteLine("Du har gjettet riktig tall");
                    running = false;
                }
                else if (tilfeldigTall > gjettetTall)
                {
                    størreEllerMindre = $"Det riktige tallet er høyere, ditt siste tall var: {gjettetTall}";
                    Console.Clear();
                }
                else if (tilfeldigTall < gjettetTall)
                {
                    størreEllerMindre = $"Det riktige tallet er lavere, ditt siste tall var: {gjettetTall}";
                    Console.Clear();
                }
            }
        }
    }
}
