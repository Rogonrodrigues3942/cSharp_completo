using System.Collections.Generic;
using System.Text;

namespace RefModifier
{
    internal class Calculator
    {
        public static void Triple(ref int x)
        {
            x *= 3;
        }
    }
}
