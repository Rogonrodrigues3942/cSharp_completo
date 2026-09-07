using System;
using System.Globalization;

namespace VectorClass1Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nVectors - Review class part 1.\n\n");

            //Studying struct vector.
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            double[] height = new double[n];

            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite a {i+1}ª altura: ");
                height[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double cumulater = 0;
            for (int i = 0; i < n; i++)
            {
                cumulater += height[i];
            }

            double average = cumulater / n;
            Console.WriteLine($"\nAVERAGE HEIGHT: {average:F2}m.");
            Console.WriteLine("Average height: " + average.ToString("F2",CultureInfo.InvariantCulture) + "m.");
        }
    }
}
