
using System.Collections.Generic;
using System;

namespace ListReview1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nClass # 77 - Listas - Assignament - part 1\n\n");

            //Observer a declaração
            List<string> names = new List<string>();
            names.Add("Rogério");

            List<int> numbers = new List<int>() { 1, 2, 3 };

            foreach (string name in names)
            {
                Console.WriteLine( name);
            }

            Console.WriteLine("\n-----------------------------------");
            foreach (int number in numbers) { Console.WriteLine(number); }
        }
    }
}
