
namespace OverloadOgDefault
{
    class Program
    {
        class OverloadExample
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        
        static void Main(string[] args)
        {
            OverloadExample calculator = new OverloadExample();
            
            Console.WriteLine("Sum med to int-parametre: " + calculator.Add(calculator.Add(calculator.Add(2,2),2), 3));
            Console.WriteLine("Sum med tre int-parametre: " + calculator.Add(2, 3, 9));
            Console.WriteLine("Sum med to double-parametere: {0}", calculator.Add(2.3, 3.9));
            int LeggSammen(int tall1 = 2, int tall2 = 3)
            {
                return tall1 + tall2;
            }
            void VisSum()
            {
                int sum = LeggSammen();
                Console.WriteLine("Summen er: " + sum);
                int sum2 = LeggSammen(2,2);
                Console.WriteLine("Den andre summen er: " + sum2);
            }
            VisSum();

        }
    }
}