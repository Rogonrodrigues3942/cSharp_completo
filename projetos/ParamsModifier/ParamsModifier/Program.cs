namespace ParamsModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estudo sobre modificador 'params'!\n\n");

            int s1 = Calculator.Sum(1, 2);
            Console.WriteLine(s1);
        }
    }
}
