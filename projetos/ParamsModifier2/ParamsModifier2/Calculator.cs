using System;


namespace ParamsModifier2
{
    class Calculator
    {
        public static double Sum(params double[] numbers)
        {
            double total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];

            }
            return total;
        }
    }
}
