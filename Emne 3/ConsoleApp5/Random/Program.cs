using System;
namespace Random
{
    class Random
    {
        static void Main(string[] args)
        {
            System.Random rnd = new System.Random();
            int randomnr = rnd.Next(0, 3);
            if (randomnr == 0)
            {
                Console.WriteLine("Tallet ble 0");
            }else if (randomnr == 1)
            {
                Console.WriteLine("Tallet ble 1");
            }
            else
            {
                Console.WriteLine("Tallet ble 2");
            }
        }
    }
    
}