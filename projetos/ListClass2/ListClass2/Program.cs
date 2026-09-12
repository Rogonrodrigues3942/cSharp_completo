namespace ListClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAula 2 - List \n\n");

            //Instanciando uma lista
            List <string> list = new List<string>();

            //Inserindo dados na lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            //inserindo item em uma posição determinada.
            Console.WriteLine("\n");
            list.Insert(2, "Marco");
            list.Insert(4, "Rafael");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nTamanho da lista: " + list.Count());
        }
    }
}
