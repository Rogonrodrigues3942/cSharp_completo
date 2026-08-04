using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nAula de funcções\n");

            Console.WriteLine("Digite 3 inteiros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine($"\n\nO maior número é: {resultado}.");

        }

        static int Maior(int a, int b, int c)
        {
            int m;

            if(a > b && a > c)
            {
                m = a;
            }
            else if(b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }

    }
}