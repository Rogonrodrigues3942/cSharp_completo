using System.Globalization;
using System.Collections.Generic;
using System;

namespace ListExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de Lista (aulas 77 e 78)");

            //1 - Fazer um programa para ler um número inteiro N e 
            Console.Write("\nDigite o tamanho da lista:  ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"O tamanho da lista é: {size}");

            List<Employee> empList = new List<Employee>();

            //2 - depois os dados(id, nome e salario) de N funcionários.
            int n = 0;
            while (n < size) {
                Console.WriteLine("\n");
                Console.WriteLine($"{n + 1}ª Inserção.");
                Console.Write("Digite o Id do colaborador: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Digite o Nome do colaborador: ");
                string name = Console.ReadLine();
                Console.Write("Digite o Salário do colaborador: ");
                double salary = double.Parse(Console.ReadLine());

                Employee employee = new Employee(id, name, salary);
                empList.Add(employee);
                n++;
            }

            Console.WriteLine("\n");
            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp);
            }

            //3 - Não deve haver repetição de id.
            //4 - Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            //5 - Para isso, o programa deve ler um id e o valor X.
            //6 - Se o id informado não existir, mostrar uma mensagem e abortar a operação.
            //7 - Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.
            //8 - Lembre - se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente. 
            //9 - Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.
        }
    }
}
