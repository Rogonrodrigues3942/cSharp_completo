using System;
using System.Collections.Generic;
using System.Text;

namespace StaticConversion
{
    class Conversion
    {
        public static double tax = 1.06;
        public static double CurrencyConversion(double quotation, double dolars)
        {
            return quotation * (dolars * tax);
        }
    }
}
