namespace Uppgift1_LinusNestorson
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Uppgift1_LinusNestorson.Helpers;

    public class PrimeCalculator
    {
        public bool PrimeCalc(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            PrimeHelper.primeList.Add(number);
            return true;
        }
    }
}