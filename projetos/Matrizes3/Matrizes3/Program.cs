namespace Matrizes3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 80 - Revisão de matrizes.\n");
            string[,] names = new string[2, 2];
            Console.WriteLine($"O tamanho da matriz de: {names.Length} posições.");
            Console.WriteLine($"Quantidades de linhas: {names.Rank};");
            Console.WriteLine($"O tamanho da 1ª dimensão: {names.GetLength(0)}");
            Console.WriteLine($"O tamanho da 2ª dimensão: {names.GetLength(1)};");
            Console.WriteLine($"\n\n Fim");
        }
    }
}
