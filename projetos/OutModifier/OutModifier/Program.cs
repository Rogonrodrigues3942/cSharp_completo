using System;

namespace OutModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nout modifier\n");

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine("\n" + triple);
        }
    }
}
