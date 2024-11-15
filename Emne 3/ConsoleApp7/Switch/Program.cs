namespace Switch
{
    class SwitchTest
    {
        public static void numberSwitch()
        { 
            Console.WriteLine("Please enter a number: ");
            var number = Console.ReadLine();

            var result = number switch
            {
                "1" => "Wrong number",
                "2" => "Wrong number",
                "3" => "Right number",
                _ => "unkown input",
            };
            Console.WriteLine($"{result}");
        }
        public static void Main(String[] args)
        {
            var menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    Console.WriteLine("Switch 1");
                    break;
                case "2":
                    Console.WriteLine("Switch 2");
                    break;
                case "3":
                    Console.WriteLine("Switch 3");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    numberSwitch();
                    break;
            }
        }
    }
}

