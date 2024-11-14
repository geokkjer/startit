using System;
namespace Random
{
    class RandomHobby
    {
        static void Main(string[] args)
        {
            System.Random rnd = new System.Random();
            int randomnr = rnd.Next(0, 3);
            Console.WriteLine("Hvem trenger en ny hobby? ");
            string name = Console.ReadLine();
            
            if (randomnr == 0)
            {
                Console.WriteLine($"{name} har nå hobbyen å strikke");
            }else if (randomnr == 1)
            {
                Console.WriteLine($"{name} er nå glad i å tegne");
            }
            else
            {
                Console.WriteLine($"{name} driver nå med Texas Hold-em");
            }
        }
    }
    
}