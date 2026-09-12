namespace ListClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAula 2 - List \n\n");

            //Instanciando uma lista
            List<string> list = new List<string>();

            //Inserindo dados na lista
            list.Add("Maria");
            list.Add("Anna");
            list.Add("Alex");
            list.Add("Bob");

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

            string s1 = list.Find(Test);
            Console.WriteLine("\n First 'A': " + s1);

            //usando a expressão lambda
            string s2 = list.Find(x => x[0] == 'R');
            Console.WriteLine("\n First 'R': " + s2);

            //última ocorrência de "A".
            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("\n Last 'A': " + s3);

            //localizando index da primeira posição 'A'.
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("\nIndex first: " + pos1);

            //localizando index da última posição 'A'.
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("\nIndex last: " + pos2);

            //localizando index da primeira posição 'A'.
            int pos3 = list.FindIndex(x => x[0] == 'R');
            Console.WriteLine("\nIndex first 'R': " + pos3);

            //Filtrando uma lista
            Console.WriteLine("\n---------------------------------\n");
            List<string> list2 = list.FindAll(x => x.Length >= 5);
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            //Removendo nós dde uma lista
            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine("\nLista original: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove("Alex");

            Console.WriteLine("\nLista após remoção de um nó: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nLista após remoção de todos os nós com a letra 'M': ");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.Remove("Ana");

            Console.WriteLine("\nLista após tentativa de remoção de um nó inexistente: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(2);

            Console.WriteLine("\nLista após remoção de um nó por posição: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveRange(0,2);

            Console.WriteLine("\nLista após remoção de uma faixa de indexes: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }


        }


        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
