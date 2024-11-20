namespace ObjectsAndEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tester Klasser og Enums");
            var box = new Box();
            box.Width = 100;
            box.Height = 100;
            box.Show();
            DaysOfWeek day = DaysOfWeek.Monday;

            switch (day)
            {
                case DaysOfWeek.Monday:
                    Console.WriteLine("Monday");
                    break;
                case DaysOfWeek.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                default: Console.WriteLine("Unknown day");
                    break;
                    
            }
        }
    }
}

