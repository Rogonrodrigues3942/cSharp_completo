namespace EF3_Comd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nVerificação de multiplos - ExFx 3\n\n");
            Console.WriteLine("Digite 2 inteiros: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int multiplo;
            if (num1 < num2)
            {
                multiplo = num2 % num1;
                if (multiplo == 0)
                {
                    Console.WriteLine("São Multiplos");
                }
                else
                {
                    Console.WriteLine("Não são Multiplos");
                }

            }
            else
            {
                multiplo = num1 % num2;
                if (multiplo == 0)
                {
                    Console.WriteLine("São Multiplos");
                }
                else
                {
                    Console.WriteLine("Não são Multiplos");
                }
            }

        }
    }
}
