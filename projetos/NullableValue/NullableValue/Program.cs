namespace NullableValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEstudo de nullable value.\n\n");

            Nullable<double> x = null;
            double? y = 10.0;

            Console.WriteLine($"Variável x : {x}");
            Console.WriteLine($"Variável y : {y}");

            
            Console.WriteLine("\nManipulando method 'GetValueOrDefault()'");
            Console.WriteLine($"Variável x : {x.GetValueOrDefault()}");
            Console.WriteLine($"Variável y : {y.GetValueOrDefault()}");

            Console.WriteLine("\nManipulando property 'HasValue()'");
            Console.WriteLine($"Variável x : {x.HasValue}");
            Console.WriteLine($"Variável y : {y.HasValue}");

            if (x.HasValue)
            {
            Console.WriteLine($"\nVariável x tem valor: {x.HasValue}");
            }
            else
            {
                Console.WriteLine("\nx is null");
            }

            if (y.HasValue)
            {
            Console.WriteLine($"\nVariável y tem valor: {y.HasValue}");
            }
            else
            {
                Console.WriteLine("\ny is null");
            }



            //Console.WriteLine("\nManipulando property 'Value()'");
            //Console.WriteLine($"Variável y : {y.Value}");
            //Console.WriteLine($"Variável x : {x.Value}");

            Console.WriteLine("\n\nCoalêscia nula - conceitos\n");
            double? z = x ?? 0.0;
            Console.WriteLine($"Variável z : {z.Value}");

            double? a = x ?? 5;
            double? b = y ?? 7;
            Console.WriteLine($"Valor da váriável 'a' {a}.");
            Console.WriteLine($"Valor da váriável 'b' {b}.");

        }
    }
}
