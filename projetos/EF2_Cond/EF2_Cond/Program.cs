using System;

namespace EF2_Cond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n*** Validar números pares e impares - ExFx 2\n\n");
            Console.Write("Digite um inteiro: ");
            int num = int.Parse(Console.ReadLine());
            int validation = num % 2;

            if (validation == 0)
            {
                Console.WriteLine("\nPAR");
            }
            else
            {
                Console.WriteLine("\nIMPAR");
            }

        }
    }
}
