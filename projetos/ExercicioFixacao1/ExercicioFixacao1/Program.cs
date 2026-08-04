using System;

namespace ExercicioFixacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Exercício Fixação 1 - Soma ***");
            Console.WriteLine("Digite o 1º inteiro");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º inteiro");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"Soma = {sum}");

        }
    }
}
