using System;
using System.Globalization;
namespace WhileCom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** Comando While ***\n\n");
            Console.Write("Digite um número: ");
            double number = double.Parse(Console.ReadLine());

            while (number >= 0)
            {
                double sqroot = Math.Sqrt(number);
                Console.WriteLine($"Raiz quadrada: {sqroot:F3}");
                Console.Write("Digite um número: ");
                number = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número negativo, finalizado processamento.");
        }
    }
}
