namespace ConsoleApp9
{
    class Loops
    {
        static void Main() 
        {
            string[] args = new string[] { "dette", "er", "gøy" };
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            bool condition = true;
            int i2 = 0;
            while (condition)
            {
                if (i2 < 10)
                {
                    Console.WriteLine("Hello world!");
                    i2++;
                }
                else
                {
                    condition = false;
                }
            } 
            
        }
    }
}