namespace Uppgift1_LinusNestorson
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Uppgift1_LinusNestorson.Helpers;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the prime generator!\n");
            while (true)
            {
                Console.WriteLine("Choose one of options below:");
                Console.WriteLine("1. Check prime \n2. See list of added primes \n3. Add next prime to the list based on current higest number och primes \n4. Exit program");
                int menuChoice = Convert.ToInt32(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();
                        CheckIfPrime();
                        break;

                    case 2:
                        Console.Clear();
                        SeeListOfPrimes();
                        break;

                    case 3:
                        Console.Clear();
                        AddNextPrime();
                        break;

                    case 4:
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input. Try again\n");
                        break;
                }
            }
        }

        private static void CheckIfPrime()
        {
            var calculator = new PrimeCalculator();
            Console.WriteLine("Please enter number you want to check: ");
            var numberChoice = Convert.ToInt32(Console.ReadLine());
            var result = calculator.PrimeCalc(numberChoice);
            if (result)
            {
                Console.WriteLine("The number is a prime and is added to the list of primes\n");
            }
            else Console.WriteLine("The number is not a prime\n");
        }

        private static void AddNextPrime()
        {
        }

        private static void SeeListOfPrimes()
        {
            Console.WriteLine("These are your logged primes\n");

            foreach (var primes in PrimeHelper.primeList)
            {
                Console.WriteLine(primes);
            }
        }
    }
}