using System.Globalization;

namespace ExFx41Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nRetangulo - Geometria - POO\n\n");

            Retangulo retangulo = new Retangulo();

            Console.Write("Enter com valor da altura: ");
            retangulo.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\nEntre com valor da largurA: ");
            retangulo.Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine($"Area: {retangulo.Area():F2}");
            Console.WriteLine($"Perimetro: {retangulo.Perimetro():F2}");
            Console.WriteLine($"Diagonal: {retangulo.Diagonal():F2}");
        }
    }
}
