
using System;
using System.Globalization;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nExercício de Fixação nº 01\n");

            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nQauantos quartos tem sua casa? ");
            int dorms = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre seu último nome, idade e altura: ");
            string[] lista = Console.ReadLine().Split(' ');
            string lastName = lista[0];
            int age = int.Parse(lista[1]);
            double height = double.Parse(lista[2]);

            Console.WriteLine("\n\n**** Saídas em tela ****\n");
            Console.WriteLine(name);
            Console.WriteLine(dorms);
            Console.WriteLine(price);
            Console.WriteLine($"{lastName} {age} {height}");
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height);

        }
    }
}
