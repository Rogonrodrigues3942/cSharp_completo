using System;
using System.Globalization;

namespace VectorClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vetores - parte 1\n\n");

            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o valor da posição: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Console.WriteLine(vect[i]);
            }
            Console.WriteLine();
            //Console.WriteLine(vect);

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine($"A média é: {avg:F2}");
        }
    }
}
