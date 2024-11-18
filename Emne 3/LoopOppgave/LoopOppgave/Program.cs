using System;

namespace LoopOppgave
{
    class Program
    {
        static void Main()
        {
            Loops();
        }

        static void Loops()
        {
            // Oppgave 1
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Terje er kul");
            }
            
            // Oppgave 2
            string sentence = "Terje er kul og hei verden fra foreach løkke";
            
            foreach (var letter in sentence)
            {
                Console.WriteLine(letter);
            }
            
            // Oppgave 3
            int number = 0;
            while (number < 10)
            {
                Console.WriteLine($"Runde nummer... {number}");
                number++;
            }
        }
        
    }


}

