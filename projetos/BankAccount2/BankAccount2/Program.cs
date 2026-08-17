using System;
using System.Globalization;

namespace BankAccount2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nConta bancária: depósito e saque.\n\n");
            Console.Write("Digite o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o nome do correntista: ");
            string customer = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/N): ");
            char depositoInicial = char.Parse(Console.ReadLine());

            Account conta; 

            if ( depositoInicial == 'S' || depositoInicial == 's')
            {
                Console.Write("\nQual o valor do depósito inicial: ");
                double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Account(accountNumber, customer, deposit);
            }
            else
            {
                conta = new Account(accountNumber, customer );
            }


            Console.Write("\nQual o valor de depósito: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposit(amount);

            Console.Write("\nQual o valor do saque: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Plunder(amount);

            Console.WriteLine(conta);
        }
    }
}
