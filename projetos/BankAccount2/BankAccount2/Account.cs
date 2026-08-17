using System;
using System.Globalization;

namespace BankAccount2
{
    class Account
    {
        public int AccountNumber {  get; private set; }
        public string Customer { get; set; }

        public double Balance {  get; private set; }

        public Account(int accountNumber, string customer)
        {
            AccountNumber = accountNumber;
            Customer = customer;
        }
        public Account(int accountNumber, string customer, double initialDeposit):this(accountNumber, customer)
        {
           
            Deposit(initialDeposit);
        }

        public void Deposit(double money)
        {
            Balance += money;
        }

        public void Plunder(double money)
        {
            Balance -= money + 5.00;
        }

        public override string ToString()
        {
            return "Número da conta: " + AccountNumber 
                + "\nNome do cliente: " + Customer 
                + "\nSaldo: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
