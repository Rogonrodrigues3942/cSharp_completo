using System.Globalization;

namespace ForCom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n*** Commando 'for' ***");
            Console.Write("\nQuantos números somaremos: ");
            int time = int.Parse(Console.ReadLine());
            double sum = 0;

            Console.WriteLine();

            for (int i = 1; i <= time; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine($"\n\nTotal = {sum}.");
        }
    }
}
