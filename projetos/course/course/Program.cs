using System.Globalization;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SByte x = 100;
            Console.WriteLine("Valor de x = " + x);

            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;


            Console.WriteLine("Valor de n1 = " + n1);
            Console.WriteLine("Valor de n2 = " + n2);
            Console.WriteLine("Valor de n3 = " + n3);
            Console.WriteLine("Valor de n4 = " + n4);

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';

            Console.WriteLine("Valor de completo: " + completo);
            Console.WriteLine("Genero: " + genero);
            Console.WriteLine("Letra: " + letra);

            double n5 = 4.5;
            float n6 = 1.98977f;

            Console.WriteLine("Valor n5: " + n5);
            Console.WriteLine("Valor n6: " + n6);

            string nome = "Maria Green";
            Console.WriteLine("Nome: " + nome);

            object obj1 = "Alex Brown";
            object obj2 = 4.5;
            Console.WriteLine("Obj1: " + obj1);
            Console.WriteLine("Obj2: " + obj2);

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            Console.WriteLine("Valor de n7: " + n7);
            Console.WriteLine("Valor de n8: " + n8);

            sbyte n9 = sbyte.MinValue;
            double n10 = double.MaxValue;
            Console.WriteLine("Valor de n9: " + n9);
            Console.WriteLine("Valor de n10: " + n10);

            Console.WriteLine("Valor n6: " + n6.ToString("F3", CultureInfo.InvariantCulture));

            int idade = 32;
            double saldo = 10.35784;
            String nome1 = "Maria";

            //placeholders
            Console.WriteLine("{0} tem {1} anos e  tem saldo igual a R$ {2:F2}.", nome1, idade, saldo);

            //interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R$ {saldo:F2}.");

            //entrada de dados via teclado.
            Console.WriteLine("Digite uma frase qualquer: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Digite uma cor;");
            string x1 = Console.ReadLine();
            Console.WriteLine("Digite a 2ª cor: ");
            string y = Console.ReadLine();
            Console.WriteLine("Digite a 3ª cor:  ");
            string z = Console.ReadLine();
            Console.WriteLine("Digite 3 cores, na mesma");
            string s = Console.ReadLine();

            Console.WriteLine("\nSaída via teclado.");
            Console.WriteLine(frase);
            Console.WriteLine(x1);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //método split
            Console.WriteLine("Digite uma frase com 3 palavras: ");
            string[] vet = s.Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //entrada de dados via teclado
            Console.WriteLine("Digite um inteiro: ");
            int n11 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o valor: {n11}.");
            Console.WriteLine("Digite um caractere: ");
            char ch1 = char.Parse(Console.ReadLine());
            Console.WriteLine($"Digitado o caractere: {ch1}");
            Console.WriteLine("Digite um decimal qualquer: ");
            double n12 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"O nº doubke é: {n12.ToString("f3", CultureInfo.InvariantCulture)}.");

            //Aplicando método Split
            Console.WriteLine("\nDigite um frase com 4 palavras: ");
            string[] strg = Console.ReadLine().Split(' ');
            string d = strg[0];
            string e = strg[1];
            string f = strg[2];
            string g = strg[3];
            Console.WriteLine($"1ª palavra: {d}");
            Console.WriteLine($"2ª palavra: {e}");
            Console.WriteLine($"3ª palavra: {f}");
            Console.WriteLine($"4ª palavra: {g}");
        }

    }
}