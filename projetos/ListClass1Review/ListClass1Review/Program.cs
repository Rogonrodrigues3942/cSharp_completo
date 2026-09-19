using System;
using System.Collections.Generic;

namespace ListClass1Review
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Class part #1 - Review.\n\n");

            //criando uma lista vazia. Instanciada sem contéudo.
            List<string> list = new List<string>();

            //criando e instanciando uma lista. Inserindo dados na lista.
            List<string> list2 = new List<string> (){ "Ana", "Alex", "Bob" };

            foreach (string item in list2) {
                Console.WriteLine(item);
            }

        }
    }
}
