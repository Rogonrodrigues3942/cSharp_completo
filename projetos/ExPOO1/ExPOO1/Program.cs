using System;

namespace ExPOO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nDados de Pessoas - Exercício 1: POO\n");

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();


            Console.Write("Entre com nome da 1ª pessoa: ");
            p1.Name = Console.ReadLine();
            Console.Write("Entre com a idade da 1ª pessoa: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.Write("\n\nEntre com nome da 2ª pessoa: ");
            p2.Name = Console.ReadLine();
            Console.Write("Entre com a idade da 1ª pessoa: ");
            p2.Age = int.Parse(Console.ReadLine());

            if( p1.Age > p2.Age)
            {
                Console.WriteLine($"\n{p1.Name} é a pessoa mais velha.");
            }
            else
            {
                Console.WriteLine($"\n{p2.Name} é a pessoa mais velha.");
            }


        }
    }
}
