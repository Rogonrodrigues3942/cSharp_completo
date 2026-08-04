namespace EF4_Comd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDigite Leia a hora inicial e a hora final de um jogo: ");

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("\n\nO JOGO DUROU " + duracao + " HORA(S).\n");
        }
    }
}
