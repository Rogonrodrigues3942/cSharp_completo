using System;
using System.Globalization;

namespace EF6_GeomFig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n**** Figuras Geométricas - ExFx 6 ****\n");
            Console.WriteLine("Digite 3 valores quaisquer: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double pi = 3.14159;

            //cálculos de figuras geométricas
            double triRet = (a * c) / 2;
            double circ = Math.Pow(c, 2) * pi;
            double trap = ((a + b) * c) / 2;
            double sqr = Math.Pow(b, 2);
            double retangule = a * b;

            //printout
            Console.WriteLine();
            Console.WriteLine($"Triângulo retângulo: {triRet}.");
            Console.WriteLine($"Circunferência: {circ}.");
            Console.WriteLine($"Trapézio: {trap}");
            Console.WriteLine($"Quadrado: {sqr}");
            Console.WriteLine($"retângulo: {retangule}");
        }
    }
}
