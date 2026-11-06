using System;

namespace Matrizes
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 80 - Matrizes\n");

            double[,] mat = new double[2, 3];

            Console.WriteLine($"O tamanho da matriz: {mat.Length}");
            Console.WriteLine($"Quantidade de linhas da matriz: {mat.Rank}");
            Console.WriteLine($"A 1ª dimensão de uma matriz: {mat.GetLength(0)}");
            Console.WriteLine($"A 2ª dimensão de uma matriz: {mat.GetLength(1)}");
        }
    }
}
