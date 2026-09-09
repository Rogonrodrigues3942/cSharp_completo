using System;


namespace ParamsModifierReview3
{
     class Calculator
    {
        public static double Sum(params double[] data)
        {
            double sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }

            return sum;
        }
    }
}
