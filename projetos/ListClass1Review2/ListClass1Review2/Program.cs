using System;
using System.Collections;

namespace ListClass1Review2
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listas - parte1 - revisão #2\n\n");
            List<string> pessoas = new List<string> { "Rogério", "Rafael", "Sameul" };

            foreach (string pess in pessoas)
            {
                Console.WriteLine($"Nome: {pess}");
            }
        }
    }
}