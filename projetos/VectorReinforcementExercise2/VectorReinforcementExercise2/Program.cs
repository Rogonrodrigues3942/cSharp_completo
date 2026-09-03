using System;

namespace VectorReinforcementExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de controle de alugel de quartos.\n\n");
            Console.Write("Deseja alugar quartos ( 1 - sim; 2 - não ):");
            int rent = int.Parse(Console.ReadLine());

            if (rent == 2)
            {
                Console.WriteLine("\nNão alugará quartos no momento.\n");
                return;
            }
            else
            {
                if(rent != 1 || rent!=2)
                {
                    Console.WriteLine("Digite número errado!");
                    return;
                }
            }

            Console.Write("Digite quantos quartos tem a pensão: ");
            int bedroom = int.Parse(Console.ReadLine());

            Student[] student = new Student[bedroom];

            while (rent == 1)
            {
                Console.Write($"\nQual quarto deseja alugar, escolha de 0 a {bedroom - 1}: ");
                int bedroomNumber = int.Parse(Console.ReadLine());

                Console.Write("Entre com nome do aluno: ");
                string name = Console.ReadLine();
                Console.Write("Entre com email do aluno: ");
                string email = Console.ReadLine();
                student[bedroomNumber] = new Student(name, email, bedroomNumber);

                Console.Write("\nDeseja alugar outro quarto ( 1 - sim; 2 - não ):");
                rent = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < bedroom; i ++ ){
                Console.WriteLine(student[i]);
            }

        }
    }
}
