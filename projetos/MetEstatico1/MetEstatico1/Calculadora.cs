
namespace MetEstatico1
{
    internal class Calculadora
    {
        public double Pi = 3.14159;

        public double Circunferencia(double r)
        {

            return 2 * r * Pi;
        }

        public double Volume(double r)
        {

            return 4 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}
