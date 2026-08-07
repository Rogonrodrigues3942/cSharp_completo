using System.Globalization;

namespace MetEstatico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Método Estático 1\n\n");

            Console.Write("Entre com valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("\nCircunferencia: " + circunferencia.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("\nVolume: " + vol.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("\nPi; " + Calculadora.Pi.ToString("F3", CultureInfo.InvariantCulture));

        }

    }
}
