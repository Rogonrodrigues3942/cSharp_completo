namespace DifeProd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDiferença de Produtos - ex3\n");

            Console.WriteLine("\nDigite o inteiro A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o inteiro B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o inteiro C: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o inteiro D: ");
            int d = int.Parse(Console.ReadLine());

            int diff = a * b - c * d;
            Console.WriteLine($"Diferença de produtos: {diff}.");
        }
    }
}
