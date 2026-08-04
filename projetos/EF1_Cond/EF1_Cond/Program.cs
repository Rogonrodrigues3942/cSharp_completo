namespace EF1_Cond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validar números negativos - EF1 if");
            Console.Write("\n\nDigite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("\nNEGATIVO");
            }
            else
            {
                Console.WriteLine("\nNÃO NEGATIVO");
            }
        }
    }
}
