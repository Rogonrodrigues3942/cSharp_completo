using System;
using System.Collections.Generic;
using System.Text;

namespace StaticConversion
{
    class Conversion
    {
        public static double Tax = 1.06;
        public static double CurrencyConversion(double quotation, double dolars)
        {
            return quotation * (dolars * Tax);
        }
    }
}
