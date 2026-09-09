namespace ParamsModifierReviwe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Params Modifier - Review \n");

            Console.Write("Digite o tamanho do vetor: ");
            int size = int.Parse(Console.ReadLine());
            double[] numbers = new double[size];

            Console.WriteLine("\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º  do vetor: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double sum1 = Calculator.Sum(numbers);
            Console.WriteLine($"\nSoma = {sum1}\n");


        }
    }
}
