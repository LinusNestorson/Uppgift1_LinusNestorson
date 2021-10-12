namespace Uppgift1_LinusNestorson
{
    using System.Linq;
    using Uppgift1_LinusNestorson.Helpers;

    public class PrimeCalculator
    {
        /// <summary>
        /// Calculates if number given by user is a prime number.
        /// </summary>
        /// <param name="number">Number input from user</param>
        /// <returns>True or false based on outcome</returns>
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

        /// <summary>
        /// Calculates the next prime number based on current highest number in list of primes.
        /// </summary>
        /// <returns>Number added to list</returns>
        public int NextPrime()
        {
            if (PrimeHelper.primeList.Any())
            {
                var currentHighestPrime = PrimeHelper.primeList.Max();
                for (int i = currentHighestPrime + 1; i < currentHighestPrime + 1000; i++)
                {
                    bool nextNum = PrimeCalc(i);
                    if (nextNum)
                    {
                        return i;
                    }
                }
                return default;
            }
            else
            {
                PrimeHelper.primeList.Add(2);
                return 2;
            }
        }
    }
}