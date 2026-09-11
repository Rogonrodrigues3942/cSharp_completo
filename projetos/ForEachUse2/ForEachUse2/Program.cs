namespace ForEachUse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n foreach - using 2\n\n");

            int [] sequencia = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("\n\n****** Usando for para laço de repetição ******\n");
            for (int i = 0; i < sequencia.Length; i++)
            {
                Console.WriteLine(sequencia[i]);
            }

            Console.WriteLine("\n\n****** Usando foreach para laço de repetição ******\n");
            foreach(int numero in sequencia)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
