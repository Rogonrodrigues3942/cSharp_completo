
namespace MetEstatico1
{
    internal class Calculadora
    {
        public static double Pi = 3.14159;

        public static double Circunferencia(double r)
        {

            return 2 * r * Pi;
        }

        public static double Volume(double r)
        {

            return 4 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}
