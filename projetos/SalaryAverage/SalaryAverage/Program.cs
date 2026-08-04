using System;
using System.Globalization;

namespace SalaryAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCálco de Média Salarial - POO 2\n\n");

            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Average average = new Average();

            Console.Write("Entre com empregado 1: ");
            e1.EmplName = Console.ReadLine();
            Console.Write("Entre salario 1:  ");
            e1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("\n\nEntre com empregado 2: ");
            e2.EmplName = Console.ReadLine();
            Console.Write("Entre salario 2:  ");
            e2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculate = average.Calculate(e1.Salary, e2.Salary);
            Console.WriteLine($"\nO salário médio é {calculate:f2}");

        }
    }
}
