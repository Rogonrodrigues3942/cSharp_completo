
using System;
using System.Globalization;

namespace ExercicioFixacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nÁrea da circunferência - ex2\n ");
            double pi = 3.14159;
            Console.WriteLine();
            Console.WriteLine("Digite um valor para o raio da circunferência: ");
            double raio = double.Parse(Console.ReadLine());
            double area = pi * raio * raio;
            Console.WriteLine($"área da circunferência: {area:F4}.");

        }
    }
}
