namespace Uppgift1_LinusNestorson
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PrimeCalculator
    {
        public bool PrimeCalc(int number)
        {
            if (number < 2)
            {
                return false;
            }

            int[] numbersBelow = new int[number];

            for (int i = 3; i < numbersBelow.Length - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}