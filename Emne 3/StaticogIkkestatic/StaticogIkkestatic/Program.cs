namespace StaticogIkkestatic
{
    class Program
    {
        static void Main(string[] args)
        {
            var place = new Places();
            place.PlaceName = "Stavern";
            place.Municipality = "Larvik";
            place.Region = "Vestfold";
            place.ShowPlace();
            var place2 = new Places();
            place2.PlaceName = "Rjukan";
            place2.Municipality = "Tinn";
            place2.Region = "Telemark";
            place2.ShowPlace();
        }

    }
}
