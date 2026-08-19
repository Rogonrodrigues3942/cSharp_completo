using System;
using System.Globalization;

namespace VectorClass1RF
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio de Reforço\n\n");

            Console.Write("Digite o tamanho do vetor:  ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {

                Console.Write($"Digite o número da {i +1}ª posição:  ");
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine($"Média: {avg:F2}");


        }
    }
}
