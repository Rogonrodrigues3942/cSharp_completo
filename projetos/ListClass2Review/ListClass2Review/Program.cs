using System.Collections.Generic;

namespace ListClass2Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Página nº 33.
            Console.WriteLine("Listas - parte 2 - aula prática de funcionalidades.\n\n");

            //lista1 declarada, instanciada vazia.
            List<string> lista1 = new List<string>();

            //lista2 declarada, instanciada com elementos.
            List<string> lista2 = new List<string> { "Roger", "Rafa", "Sammy" };

            Console.WriteLine("\n\nLista nº 2:\n");
            foreach (string pes in lista2)
            {
                Console.WriteLine(pes);
            }

            Console.WriteLine("\n\n----------------------------------------------------\n");

            //inserindo elementos, métodos: Add() e Insert();
            lista1.Add("Maria");
            lista1.Add("Alex");
            lista1.Add("Bob");
            lista1.Add("Aanna");

            foreach (string pes in lista1)
            {
                Console.WriteLine(pes);
            }

            Console.WriteLine("\n\nUtilizando o método 'Insert()' na lista 1.\n");
            lista1.Insert(2, "Marco");
            foreach (string pes in lista1)
            {
                Console.WriteLine(pes);
            }

            Console.WriteLine($"\n\nA lista nº 1 possui {lista1.Count()} elementos.\n\n");

            Console.WriteLine("\n\nEncontrar o primeiro da lista que satisfaça um predicado: \r\n");


            Console.WriteLine("\n\nEncontrar o último elementos da lista que satisfaça um predicado: \r\n");


        }
    }
}