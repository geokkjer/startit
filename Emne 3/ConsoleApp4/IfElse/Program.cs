namespace CompareApp
{
    class IsEqualOr
    {
        private static int num = 10;
        private static int num2 = 10;
        private static bool IsEqual = false;
        static void Main(string[] args)
        {
           Compare();
           UnEqual(5, 5);
           IsThirty(25, 5);
        }

        static void Compare()
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

        static int UnEqual(int num1, int num2)
        {
            if (num1 != num2)
            {
               return num1 + num2; 
            }
            else
            {
                return num1 * num2;
            } 
        }

        static bool IsThirty(int num, int num2)
        {
            if (num + num2 == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

