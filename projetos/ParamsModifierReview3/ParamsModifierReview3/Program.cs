using System;

namespace ParamsModifierReview3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nParams Modifier - Review #2\n");
            Console.Write("\nDigite o tamanho do vetor de numeros: ");
            int size = int.Parse(Console.ReadLine());
            double[] numbers = new double[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"\nDigite o {i+1}º número do vetor: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double sum = Calculator.Sum(numbers);
            Console.Write($"\nSoma: {sum}");

            Console.WriteLine("\n");
        }
    }
}
