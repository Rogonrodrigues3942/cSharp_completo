using System;
using System.Globalization;

namespace Hostel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** Auguel de quatos ***\n\n");

            int n = 10;
            Bedroom[] room = new Bedroom[n];
            Console.Write("Deseja aluga um dormitório ( 1 - Sim / 2 - Não ): ");
            int flag = int.Parse(Console.ReadLine());

            if (flag != 1)
            {
                Console.WriteLine("\nQuartos não foram alugados.\n");
                return;
            }

            
            while (flag == 1)
            {
                Console.Write("\nEscolha um dormitório está vago, de 0 a 9 : ");
                int bedrroom = int.Parse(Console.ReadLine());
                string name = "";
                string email = "";

                if (room[bedrroom] == null)
                {
                    Console.WriteLine($"\nO dormitório #{bedrroom} está disponível.");
                    Console.Write("Digite o nome do estudante: ");
                    name = Console.ReadLine();
                    Console.Write("Digite o email do aluno: ");
                    email = Console.ReadLine();
                    room[bedrroom] = new Bedroom { Name = name, Email = email, Room = bedrroom };
                    Console.Write("Deseja alugar um outro dormitório ( 1 - Sim / 2 - Não ): ");
                    flag = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"\nO dormitório #{bedrroom} está locado.");
                    Console.Write("Deseja escolher outro dormitório ( 1 - Sim / 2 - Não ): ");
                    flag = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nLista de dormitórios ocupados: ");
            for (int i = 0; i < n; i++)
            {
                if (room[i] != null) Console.WriteLine("\n" + room[i]);
            }
        }
    }
}
