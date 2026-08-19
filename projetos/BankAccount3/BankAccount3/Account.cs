using System.Globalization;

namespace BankAccount3
{
     class Account
    {
        public int AccountNumber {  get; private set; }
        public string Name { get; set; }
        public double Balance {  get; private set; }

        public Account(int  accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
        }

        public Account(int accountNumber, string name, double balance) : this(accountNumber, name)
        {
            Balance = balance;
        }


        public override string ToString()
        {
            return "\nNúmero da conta: " + AccountNumber
                +"\nNome do correntista: " + Name
                + "\nSaldo da conta:  R$ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
