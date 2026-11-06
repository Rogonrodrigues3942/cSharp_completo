namespace Matrizes2
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Revisão de Matrizes - aula 80");

            double[,] flutuante = new double[2, 4];

            Console.WriteLine($"Tamanho da matriz - {flutuante.Length};");
            Console.WriteLine($"Quandade de linhas: {flutuante.Rank};");
            Console.WriteLine($"Tamanho da 1ª dimensão: {flutuante.GetLength(0)};");
            Console.WriteLine($"Tamanho da 2ª dimensão: {flutuante.GetLength(1)};");

        }
    }
}
