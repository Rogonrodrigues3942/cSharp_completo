using System;
using System.Collections.Generic;
using System.Text;

namespace StaticConversion
{
    class Conversion
    {
        public static double CurrencyConversion(double quotation, double dolars)
        {
            return quotation * (dolars * 1.06);
        }
    }
}
