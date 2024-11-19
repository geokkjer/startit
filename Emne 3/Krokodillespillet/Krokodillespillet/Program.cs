using System;

namespace KrokodilleSpillet
{
    class Program
    {
        static int poeng = 0;
        static bool running = true;
        static string rightAnswer; 
        static void Main(string[] args)
        {
           ProgramLoop(); 
        }

        static void ProgramLoop()
        {   
            
            while (running == true)
            {
                var rand1 = new Random();
                var rand2 = new Random();
                int randomNumber = rand1.Next(0,11);
                int randomNumber2 = rand2.Next(0,11);
               
                Console.WriteLine("Skriv inn riktig > < eller =. Alle andre tegn avslutter programmet");
                Console.WriteLine($"Du har {poeng} poeng");
                Console.WriteLine($"Hva er riktig tegn i utrykket {randomNumber} _ {randomNumber2}");
                string answer = Console.ReadLine();
                GetRightAnswer(randomNumber, randomNumber2);
                CheckAnswer(answer); 
            }
        }
        static string GetRightAnswer(int rand1, int rand2)
        { 
            if (rand1 == rand2)
            {
                rightAnswer = "=";
            } else if (rand1 > rand2)
            {
                rightAnswer = ">";
            } else if (rand1 < rand2)
            {
                rightAnswer = "<";
            }
            return rightAnswer;
        }

        static void CheckAnswer(string answer)
        {
            if (answer != "<" && answer != ">" && answer != "=")
            {
                Console.WriteLine("På gjensyn :-)");
                running = false;
            }
            else if (answer == rightAnswer)
            {
                PrintResponse(true);
                poeng++;
                Console.Clear();

            } else if(answer != rightAnswer)
            {
                PrintResponse(false);
                poeng--;
                Console.Clear();
            }
            
        }

        static void PrintResponse(bool arg)
        {
            if (arg == true)
            {
                Console.WriteLine($"\nDet er riktig");
                Console.WriteLine($"\nTrykk en tast for å fortsette");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\nDet er feil");
                Console.WriteLine($"\nRiktig svar var {rightAnswer}");
                Console.WriteLine($"\nTrykk en tast for å prøve igjen");
                Console.ReadKey();
            }
        }
    }
}

