namespace ObjectsAndEnums
{

    public class Box
    {
        public int Width;
        public int Height;

        internal void Show()
        {
            Console.WriteLine("Boksen har disse målene: " + Width + "x" + Height);
        }

    }
}