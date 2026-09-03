namespace StructSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEstudo do tipo struct.\n");

            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

        }
    }
}
