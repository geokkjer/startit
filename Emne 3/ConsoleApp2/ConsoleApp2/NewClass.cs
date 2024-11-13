namespace ConsoleApp2;

public class NewClass
{
   private int tall = 1;
   private float desimalTall = 1.0f;
   double desimalTall2 = 1.01;
   decimal desimalTall3 = 1.01M;
   
   char bokstav = 'A';
   string tekst = "Hei";
   
   bool santUsant = true; //eller false
   
   int[] tallArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
   string[] tekstArray = { "A", "B", "C", "D", "E" };
   
   List<int> ListeMedTall = new List<int>();

   public int NumberFive()
   {
      return 5;
   }
}