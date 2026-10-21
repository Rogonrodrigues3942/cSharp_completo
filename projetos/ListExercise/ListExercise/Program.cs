using System;
using System.Globalization;
using System.Xml.Linq;

namespace ListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nAula #79 - Exercício de Listas\n");

            Console.Write("\nEntre com o tamanho da lista de colaboradores: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Criando a lista de funcionpario para teste.
            List<Employee> empList = new List<Employee>();

            int number = 0;

            Console.WriteLine("\n");
            while (number < n)
            {
                Console.Write("Digite o id do colaborador: ");
                int id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite o nome do colaborador: ");
                string name = Console.ReadLine();
                Console.Write("Digite o salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Checking Id registered
                Employee checkId = empList.Find(x => x.Id == id);

                if (checkId == null)
                {
                    Console.WriteLine($"\nCadastro nº: {number + 1} realizado.\n");
                    empList.Add(new Employee(id, name, salary));
                    //empList.Add(empObj);
                    number++;
                }
                else
                {
                    Console.WriteLine($"\n{checkId.Id} já cadastrado!");
                }

            }

            Console.WriteLine("\nLista antes do aumento:\n");
            foreach (Employee employee in empList)
            {
                Console.WriteLine("\n");
                Console.WriteLine(employee);
            }


            //trabalhando o aumento de salário
            Console.WriteLine("\n localizar o colaborador e reajuste salário:\n");
            Console.Write("Digite o id do colaborador para reajuste salarial: ");
            int increaseId = int.Parse(Console.ReadLine());
            Console.Write("Digite o índice de reajuste: ");
            double index = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Employee increment = empList.Find(emp => emp.Id == increaseId);

            if (increment != null)
            {
                Console.WriteLine($"\nLocalizado colaborador: {increment}");
                double adjusment = (index /100) + 1;
                increment.Salary *= adjusment ;
                Console.WriteLine($"\nSalario de incrementado: {increment.Salary}");
            }

            Console.WriteLine("\nNova lista apresentando o reajuste para o colaborador: ");
            foreach (Employee employee in empList)
            {
                Console.WriteLine("\n");
                Console.WriteLine(employee);
            }

            //Console.Write("\nInsira o índice de reajuste salarial:  ");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine($"O reajuste salarial é de {x:F2}%");
            //Employee adjustment = new Employee();
            //double index = adjustment.Index(x);

        }
    }
}


/*
 * Passo a Passo:
 * 
 * 1 - Fazer um programa para ler um número inteiro N de registros de funcionários;
 * 2 - Construir classe funcionário, com os dados (id, nome e salario) de N funcionários;
 * 3 - Não deve haver repetição de id;
 * 4 - Inserir o funionário na lista;
 * 5 - Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário;
 * 6 - Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma mensagem e abortar a operação;
 * 7 - Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.
 * 
*/