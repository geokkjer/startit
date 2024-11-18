using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileLoop();
            //DoWhileLoop();
            forEachLoop();
            ForLoop();
        }
        // while
        static void WhileLoop()
        {
            bool shouldRun = true;
            int i = 0;

            while (shouldRun == true)
            {
                if (i >= 19)
                {
                    shouldRun = false;
                }
                Console.WriteLine($"Hei verdi: {i}");
                i++;
            }
        }
        
        //do while
        static void DoWhileLoop()
        {
            do
            {
                Console.WriteLine("Doing while...");
            } while (true);
        }
        
        // foreach
        static void forEachLoop()
        {
            int[] numberArray = {1,2,3,4,5,6,7,8,9,10};

            foreach (var number in numberArray)
            {
             Console.WriteLine(number);   
            }
        }
        
        // For loop
        static void ForLoop()
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"For loop...{i}");
            }
        }
    }
}

