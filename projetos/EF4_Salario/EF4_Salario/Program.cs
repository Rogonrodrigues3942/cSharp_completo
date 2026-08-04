using System;
using System.Globalization;

namespace EF4_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCálculo de Salários - EXFX4\n");
            Console.WriteLine("Digite a identificação do colaborador: ");
            string id = Console.ReadLine();
            Console.WriteLine("Digite quantidade de horas trabalhadas: ");
            double hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora de trabalho: ");
            double paymentHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //cálculo do salário
            double salary = (hours * paymentHour);

            Console.WriteLine("\n\n **** Saida de dados *** \n");
            Console.WriteLine($"Employee Id: {id}");
            Console.WriteLine($"Salary: R$ {salary:f2}");
        }
    }
}
