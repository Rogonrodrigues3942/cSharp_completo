using System;
using System.Globalization;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Controle de Produto em Estoque - POO");

            Console.WriteLine("\nInsira os dados do produto.\n\n");

            Console.Write("Insira o nome do produto: ");
            string prodName = Console.ReadLine();

            Console.Write("Insira a quantidade: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Insira o preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product p = new Product
            {
                ProdName = prodName,
                Quantity = quantity,
                Price = price
            };

            Console.WriteLine($"\nDados do produto: {p}");

            Console.Write("\nAdiciona novas unidades: ");
            quantity = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantity);
            Console.WriteLine($"\nDados do produto: {p}");


            Console.Write("\nRemova unidades: ");
            quantity = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantity);
            Console.WriteLine($"\nDados do produto: {p}");
        }
    }
}
