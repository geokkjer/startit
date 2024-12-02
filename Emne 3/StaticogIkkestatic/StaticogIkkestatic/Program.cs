namespace StaticogIkkestatic
{
    class Program
    {
        static void Main(string[] args)
        {
            var place = new Places( "Stavern","Larvik", "Vestfold");
            
            var place2 = new Places("Rjukan","Tinn","Telemark");
           
            place.ShowPlace();
            place2.ShowPlace();
        }

    }
}
