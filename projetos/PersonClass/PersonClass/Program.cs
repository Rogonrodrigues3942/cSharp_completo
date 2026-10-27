using System.Collections.Generic;
using System.Globalization;

namespace PersonClass
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person person = new Person("Rogério", 
                DateOnly.Parse("January 13 1971"), 
                "São Paulo", 
                9999.99);

            Console.WriteLine(person);
        }
    }
}
