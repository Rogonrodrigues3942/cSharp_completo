using System;
using System.Security.AccessControl;

namespace VectorReinforcementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de Fixação\n\n");


            Console.Write("\nQuantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            Student[] vect = new Student[n];
            //for (int i = n;  i > 0; i++)
            //{

            //}
            Console.Write("Deseseja alugar (1 - sim, 2 - não ):  ");
            int alugar = int.Parse(Console.ReadLine());

            if (alugar == 2)
            {
                Console.WriteLine("Não alugou nenhum quarto.");
                return;
            }

            while (alugar == 1)
            {
                Console.WriteLine("Registrando dados da locação.\n");

                Console.Write("Nome do locatário: ");
                string lessee = Console.ReadLine();
                Console.Write("Email do locatário: ");
                string email = Console.ReadLine();
                Console.Write($"Qual quarto deseja alugar, esolha (de 0 a {n - 1}): ");
                int bedroom = int.Parse(Console.ReadLine());
                vect[bedroom] = new Student(lessee, email, bedroom);

                Console.Write("\nDeseseja alugar (1 - sim, 2 - não ): ");
                alugar = int.Parse(Console.ReadLine());

            }
            if (vect.Length > 0)
            {
                Console.WriteLine("\n\nQuartos Alugados: \n");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(vect[i]);
                }
            }

            Console.WriteLine("Fim do processo. \n");

        }
    }
}
