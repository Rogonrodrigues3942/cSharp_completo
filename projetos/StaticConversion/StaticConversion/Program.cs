using System;
using System.Globalization;

namespace StaticConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nConversor Dólar Americano para Real Brasil\n\n");
            Console.Write("Cotação do US$ em R$: ");
            double quotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantia de compra de US$: ");
            double dolars = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double reais = Conversion.CurrencyConversion(quotation, dolars);
            Console.WriteLine("\nValor a ser pago: R$ " + reais.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
