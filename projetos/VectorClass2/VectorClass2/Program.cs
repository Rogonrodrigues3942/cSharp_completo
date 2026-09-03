using System;
using System.Globalization;

namespace VectorClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vetor de Produtos\n\n");

            Console.Write("Digite a quantidade de produtos para cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"\nProduto: {vect[i].Name}.");
            //    Console.WriteLine($"Preço: {vect[i].Price:F2}");
            //}

            for (int i = 0; i < n; i++) {

                Console.Write("\nDigite o nome do produto:  ");
                string name = Console.ReadLine();

                Console.Write("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = name, Price = price };
            }


            double sum = 0;
            for(int i  = 0; i < n; i++ )
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine();
            Console.WriteLine($"AVERAGE PRICE: ${avg:F2}.");

        }
    }
}
