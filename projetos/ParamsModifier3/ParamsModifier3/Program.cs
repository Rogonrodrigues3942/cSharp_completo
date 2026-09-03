namespace ParamsModifier3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estudo sobre modificador 'params'!\n\n");

            Console.Write("Quantos qual o tamanho de vetor de números: ");
            int size = int.Parse(Console.ReadLine());
            double[] numbers = new double[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

          
            double t1 = Calculator.Sum(numbers);
            Console.WriteLine($"\nTotal: {t1}.");


        }
    }
}
