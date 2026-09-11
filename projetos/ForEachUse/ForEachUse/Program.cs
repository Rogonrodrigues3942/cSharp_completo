namespace ForEachUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nforeach\n\n");

            string[] names = new string[] { "Rogério", "Rafael", "Samuel" };

            Console.WriteLine("\n ---- Usando for para repetição ---- \n ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("\n ---- Usando foreach para repetição ---- \n ");
            foreach( string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
