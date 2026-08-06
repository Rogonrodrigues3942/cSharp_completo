using System.Globalization;

namespace MetEstatico1
{
    class Program
    {
        static double Pi = 3.14159;
        static void Main(string[] args)
        {
            Console.WriteLine("Método Estático 1\n\n");

            Console.Write("Entre com valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("\nCircunferencia: " + circunferencia.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("\nVolume: " + vol.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("\nPi; " + Pi.ToString("F3", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double r) {

            return 2 * r * Pi;
        }

        static double Volume(double r) { 

            return 4/3 * Pi * Math.Pow(r, 3);
        }   
    }
}
