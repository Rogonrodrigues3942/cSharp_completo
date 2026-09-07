using System;
using System.Globalization;

namespace VectorClass2Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nVectors - Review class part 2.\n\n");
            Console.Write("Qual o tamanho do vetor de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] prod = new Product[n];
            Console.WriteLine("\nInsira os produtos no estoque.\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.Write("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                prod[i] = new Product { Name = name, Price = price };
            }

            Console.WriteLine("\nListe os produtos no armazém.\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n" + prod[i]);
            }

            double cum = 0.0;

            Console.WriteLine("\nAcumulando valores do produtos.\n");
            for (int i = 0; i < n; i++)
            {
                cum += prod[i].Price;
            }

            double average = cum / n;

            Console.WriteLine("O valor total de estoque é: $ " + cum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor médio de estoque é: $ " + average.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}