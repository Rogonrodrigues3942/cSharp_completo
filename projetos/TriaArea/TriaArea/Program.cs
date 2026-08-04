using System;
using System.Globalization;

namespace TriaArea
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nComparar áreas de triângulos.\n");
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Digite as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDigite as medidas do triângulo y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Processando cálculos de áreas de X e Y
            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p *(p -xA) * (p - xB) * (p - xC));

             p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
