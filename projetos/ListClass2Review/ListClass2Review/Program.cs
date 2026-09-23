using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

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

            Console.WriteLine("\n\n----------------------------------------------------\n");
            Console.WriteLine("\n\nUtilizando o método 'Insert()' na lista 1.\n");
            lista1.Insert(2, "Marco");
            foreach (string pes in lista1)
            {
                Console.WriteLine(pes);
            }

            Console.WriteLine("\n\n----------------------------------------------------\n");

            Console.WriteLine($"\n\nA lista nº 1 possui {lista1.Count()} elementos.\n\n");

            Console.WriteLine("\n\n----------------------------------------------------\n");
            Console.WriteLine("\n\n1) Encontrar o primeiro da lista que satisfaça um predicado: \r\n");

            string s1 = lista1.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome que começa com 'A': " + s1);

            string s2 = lista1.Find(x => x[1] == 'a');
            Console.WriteLine("Primeiro nome que contenha 'a' na segunda posição: " + s2);

            string s3 = lista1.Find(x => x[2] == 'b');
            Console.WriteLine("Primeiro nome que contenha 'b' na terceira posição: " + s3);

            Console.WriteLine("\n\n----------------------------------------------------\n");
            Console.WriteLine("\n\n2)Encontrar o último elementos da lista que satisfaça um predicado: \r\n");

            string s4 = lista1.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último  nome que começa com 'A': " + s4);

            string s5 = lista1.FindLast(x => x[1] == 'a');
            Console.WriteLine("Último nome que contenha 'a' na segunda posição: " + s5);

            string s6 = lista1.FindLast(x => x[2] == 'b');
            Console.WriteLine("Primeiro nome que contenha 'b' na terceira posição: " + s6);

            Console.WriteLine("\n\n----------------------------------------------------\n");
            foreach (string name in lista1)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n\n----------------------------------------------------\n");
            Console.WriteLine("\n3) Encontrar primeira posição de elemento da lista que satisfaça um predicado: list.FindIndex \n");
            int s7 = lista1.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position with word is 'A': " + s7);

            Console.WriteLine("\n\n----------------------------------------------------\n");
            Console.WriteLine("\n4) Encontrar última posição de elemento da lista que satisfaça um predicado: list.FindLastIndex \n");
            int s8 = lista1.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position with word is 'A': " + s8);

            Console.WriteLine("\n\n----------------------------------------------------\n");
            Console.WriteLine("\n5) Filtrar a lista com base em um predicado.\n");
            List<string> lista3 = lista1.FindAll(x => x.Length == 5);
            foreach (string name in lista3)
            {
                Console.WriteLine(name);
            }
            

            Console.WriteLine("\n\n----------------------------------------------------\n");
            Console.WriteLine("Remover elementos da lista: Remove");

            Console.WriteLine("\n\n----------------------------------------------------\n");
            Console.WriteLine("Remover elementos da lista: RemoveAll");

            Console.WriteLine("\n\n----------------------------------------------------\n");
            Console.WriteLine("Remover elementos da lista: RemoveAt, ");

            Console.WriteLine("\n\n----------------------------------------------------\n");
            Console.WriteLine("Remover elementos da lista: RemoveRange");

            Console.WriteLine("\n\n----------------------------------------------------\n");

        }
    }
}