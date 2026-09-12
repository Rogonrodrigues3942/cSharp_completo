using System.Collections.Generic;

namespace ListClass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 1 - Listas\n\n");

            //Instanciada uma lista vazia.
            List<string> list = new List<string>();

            //Instanciada uma lista com elementos.
            List<string> list2 = new List<string>{"Rogério", "Rafael" };

            foreach (string nome in list2)
            {
                Console.WriteLine(nome);
            }



        }
    }
}
