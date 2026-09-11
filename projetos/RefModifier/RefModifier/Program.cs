using System;

namespace RefModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nref modifier\n\n");

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
