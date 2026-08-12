using Problem2;
using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEncapsulamento - POO \n\n");

            Product p = new Product("TV 32'", 999.99, 10);

            Console.WriteLine(p);
            Console.WriteLine("\n" + p.GetNome());

            p.SetNome("TV 4K");

            Console.WriteLine("\n" + p.GetNome());
            Console.WriteLine("\n" + p.GetPrice());
            Console.WriteLine("\n" + p.GetQuantity());
        }
    }
}
