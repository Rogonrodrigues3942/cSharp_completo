using System;
using System.Globalization;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEncapsulamento - POO \n\n");

            Product p = new Product("TV 32'", 500.00, 10);

            Console.WriteLine(p);
            Console.WriteLine("\n" + p.ProdName);

            p.ProdName = "TV 4K";

            Console.WriteLine("\n" + p.ProdName);
            Console.WriteLine("\n" + p.Price);
            Console.WriteLine("\n" + p.Quantity);
        }
    }
}
