namespace CompareApp
{
    class IsEqualOr
    {
        private static int num = 10;
        private static int num2 = 10;
        private static bool IsEqual = false;
        static void Main(string[] args)
        {
            if (num == num2)
            {
                Console.WriteLine("Equal");
                IsEqual = true;
            }
            else
            {
                Console.WriteLine("Not Equal");
                IsEqual = false;
            }

            if (IsEqual)
            {
                num++;
                Console.WriteLine(num);
            }
            else
            {
                num--;
                Console.WriteLine(num);
            }
        }
    }
}

