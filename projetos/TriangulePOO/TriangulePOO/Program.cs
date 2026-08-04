using System.Globalization;

namespace TriangulePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nÁrea do Triângulo - POO\n\n");

            //Instaciaando objetos.
            Triangule x, y;
            x = new Triangule();
            y = new Triangule();


            Console.WriteLine("Digite as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDigite as medidas do triângulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //Processando cálculos de áreas de X e Y
            double areaX = x.Area();


            double areaY = y.Area();

            //Saída no terminal
            Console.WriteLine($"\nA área do triângilo X: {areaX:F4}");
            Console.WriteLine($"A área do triângilo Y: {areaY:F4}");

            if (areaX > areaY)
            {
                Console.WriteLine("\nMaior área: triângulo X.\n\n");
            }
            else
            {
                Console.WriteLine("\nMaior área: triângulo Y.\n\n");
            }


        }
    }
}
