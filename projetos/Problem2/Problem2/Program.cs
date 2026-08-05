using System;
using System.Globalization;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Controle de Produto em Estoque - POO");

            Product p = new Product();

            Console.WriteLine("\nInsira os dados do produto.\n\n");
            Console.Write("Insira o nome do produto: ");
            p.ProdName = Console.ReadLine();
            Console.Write("Insira a quantidade: ");
            p.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Insira o preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nDados do produto: {p}");

            Console.Write("\nAdiciona novas unidades: ");
            int quantity = int.Parse(Console.ReadLine()) ;
            p.AdicionarProdutos(quantity);
            Console.WriteLine($"\nDados do produto: {p}");


            Console.Write("\nRemova unidades: ");
            quantity = int.Parse(Console.ReadLine()) ;
            p.RemoverProdutos(quantity);
            Console.WriteLine($"\nDados do produto: {p}");
        }
    }
}
