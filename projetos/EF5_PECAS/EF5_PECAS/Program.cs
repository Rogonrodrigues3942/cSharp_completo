using System;
using System.Globalization;

namespace EF5_PECAS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\nCálculo de Peças - ExFx5\n");
            string peaceNumber, peaceNumber2;
          
            Console.WriteLine("Digite o código da peça 1: ");
            peaceNumber = Console.ReadLine();
            Console.WriteLine("Insira a quantidade de peças");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário da peça 1: ");
            double peaceValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da peça 2: ");
            peaceNumber2 = Console.ReadLine();
            Console.WriteLine("Insira a quantidade de peças");
            int quantity2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário da peça 1: ");
            double peaceValue2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalValue = quantity * peaceValue;
            double totalValue2 = quantity2 * peaceValue2;
            double sum = totalValue + totalValue2;

            Console.WriteLine($"VALOR A PAGAR R$ {sum:F2}.");

            //saída no terminal



        }
    }
}
