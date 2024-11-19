using System;

namespace TekstTukling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Velg 1 for å snu tekst eller 2 for å bytte e med a i tekst");
            string valg = Console.ReadLine();
            if (valg == "1")
            {
                Console.Clear();
                Console.WriteLine("Skriv inn tekst som skal snus: ");
                string reverseText = Console.ReadLine();
                ReverseTekst(reverseText);

            } else if (valg == "2")
            {
                Console.Clear();
                Console.WriteLine("Skriv inn tekst hvor a skal erstatte e: ");
                string vowelSwap = Console.ReadLine();
                SwapVowels(vowelSwap);
            }
            else
            {
                Console.WriteLine("Velg 1 eller 2!!");
            }
            
        }

        static void ReverseTekst(string reverseText)
        {
            for (int i = (reverseText.Length - 1) ; i >= 0; i--)
            {
                Console.Write(reverseText[ i ]);
            }
        }

        static void SwapVowels(string vowelSwap)
        {
            string word = "";

            foreach (var letter in vowelSwap)
            {
                if (letter == 'e')
                {
                    word += 'a';
                }
                else
                {
                    word += letter;
                }

            }
            Console.WriteLine(word);
        }
    }
}

