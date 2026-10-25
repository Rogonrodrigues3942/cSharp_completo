using System;

namespace ConstructorReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class # 52 - Constructor \n");

            //instantiating product #1
            Product p1 = new Product("TV 32'", 999.99, 2);
            Console.WriteLine($" Produto: {p1}");

            //instantiating product #2
            Product p2 = new Product("Landry Machine", 1999.35, 1);
            Console.WriteLine($" Produto: {p2}");


        }
    }
}
