using System.Globalization;
using System.Collections.Generic;
using System;

namespace ListExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de Lista (aulas: 77 e 78)");

            //1 - Fazer um programa para ler um número inteiro N e 
            Console.Write("\nDigite o tamanho da lista:  ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"O tamanho da lista é: {size} registro(s).");

            //2 - Criada a lista da classe de colaboradores
            List<Employee> empList = new List<Employee>();

            //3 - Cadastrar colaboradores. Inserir os dados(id, nome e salario) de N funcionários na lista Employee.
            int n = 0;
            while (n < size)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"{n + 1}ª Inserção.");
                Console.Write("Digite o Id do colaborador: ");
                int id = int.Parse(Console.ReadLine());

                //4 - Não deve haver repetição de id.
                Employee idChecking = empList.Find(e => e.Id == id);
                if (idChecking == null)
                {
                    Console.Write("Digite o Nome do colaborador: ");
                    string name = Console.ReadLine();
                    Console.Write("Digite o Salário do colaborador: ");
                    double salary = double.Parse(Console.ReadLine());

                    Employee employee = new Employee(id, name, salary);
                    empList.Add(employee);
                    n++;
                }
                else
                {
                    Console.WriteLine($"O id: '{id}' está cadastrado na lista. Insira funcionário com novo id.");

                }


            }

            Console.WriteLine("\n");
            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp);
            }

            //5 - Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            //6 - Para isso, o programa deve ler um id e o valor X.
            //7 - Se o id informado não existir, mostrar uma mensagem e informar um id válido cadastrado na lista.

            bool increment = true;
            while (increment)
            {
                Console.Write("\nDigite o id para aumento: ");
                int idIncrement = int.Parse(Console.ReadLine());
                Employee incrementSalary = empList.Find(e => e.Id == idIncrement);

                if (incrementSalary != null)
                {
                    Console.Write("Digite o índice do reajuste: ");
                    double index = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double adjusment = (100 + index) / 100;
                    Console.WriteLine($"Índice de reajuste: {adjusment}");

                    Console.WriteLine($"Salário reajustado: $ {incrementSalary.Salary *= adjusment}");
                    increment = false;
                }
                else
                {
                    Console.WriteLine("Not found employee! Locate recorded employee by id validated.");
                }

            }

            //8 - Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.
            //9 - Lembre - se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente. 
            //10 - Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.

            Console.WriteLine("\n");
            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
