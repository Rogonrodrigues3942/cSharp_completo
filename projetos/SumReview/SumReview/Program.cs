using System;

namespace SumReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vetor dinâmico. \n");

            Console.Write("\nDigite um número inteiro, para o tamanho do vetor: ");
            int size = int.Parse(Console.ReadLine());
            double[] numbers = new double[size];

            Console.WriteLine("\n");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Digite o {i+1}º número: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            double sum = Calculator.Sum(numbers);
            Console.WriteLine($"\nTotal: {sum}.\n\n ");
        }
    }
}
