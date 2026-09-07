using System;
using System.Globalization;

namespace VectorReinfExReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nReview - Vector Exercise\n\n");

            int n = 10;
            Room[] room = new Room[n];
            Console.Write("\nDeseja aluga quarto ( 1 - Sim / 2 - Não ): ");
            int rent = int.Parse(Console.ReadLine());

            while (rent == 1)
            {
                Console.Write("\nEscolha o quarto (de 0 a 9) : ");
                int bedroom = int.Parse(Console.ReadLine());
                string name;
                string email;


                Console.WriteLine($"\nVerificado o quarto  #{bedroom} está ocupado. ");
                if (room[bedroom] == null)
                {
                    Console.WriteLine($"\nO quarto  #{bedroom} está livre. ");
                    Console.Write("Insira o nome do estudante: ");
                    name = Console.ReadLine();
                    Console.Write("Insira o email do estudante: ");
                    email = Console.ReadLine();
                    room[bedroom] = new Room { Name = name, Email = email, Bedroom = bedroom };
                }
                else
                {
                    Console.WriteLine($"\nO #{bedroom} está ocupado. Escolha outro dormitório! \n");
                }


                Console.Write("\nDeseja aluga outro quarto ( 1 - Sim / 2 - Não ): ");
                rent = int.Parse(Console.ReadLine());
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (room[i] != null)
                {
                    count++;
                }
            }

            //Console.WriteLine(count);

            if (count > 0)
            {
                Console.WriteLine("\nBusy rooms list: \n");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("\n" + room[i]);
                }
            }
            else
            {
                Console.WriteLine($"\nO pensionato não alugou nenhum dormitório.");
            }
        }
    }
}
