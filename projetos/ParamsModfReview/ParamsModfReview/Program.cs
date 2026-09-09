namespace ParamsModfReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Params Modifier\n\n");

            int sum1 = Calculator.Sum(3, 2);
            int sum2 = Calculator.Sum(1, 2, 3, 4);

            Console.WriteLine($"Valor da soma 1: {sum1}.");
            Console.WriteLine($"Valor da soma 2: {sum2}.");
        }
    }
}
