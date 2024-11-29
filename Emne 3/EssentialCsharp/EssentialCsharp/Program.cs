namespace EssentialCsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
           bool ignoreCase = true;
           string option = "/help";
           
           int comparison = string.Compare(option, "/Help", ignoreCase);
           bool isHelpREquested = (comparison == 0);
           Console.WriteLine($"Help Requested: {isHelpREquested}");
           Console.WriteLine("\u0029");
        }
    }
}