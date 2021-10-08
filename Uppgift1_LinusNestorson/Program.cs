﻿namespace Uppgift1_LinusNestorson
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using Uppgift1_LinusNestorson.Helpers;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the prime generator!\n");
            while (true)
            {
                try
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
                            Console.WriteLine("Invalid option. Try again with one of the numbers in the menu\n");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nSomething went wrong, please try again.");
                    Console.WriteLine($"Error message: {ex.Message}\n");
                }
            }
        }

        private static void CheckIfPrime()
        {
            var primeCalc = new PrimeCalculator();
            Console.WriteLine("Please enter number you want to check: ");
            var numberChoice = Convert.ToInt32(Console.ReadLine());
            var result = primeCalc.PrimeCalc(numberChoice);
            if (result)
            {
                Console.WriteLine("The number is a prime and is added to the list of primes\n");
            }
            else Console.WriteLine("The number is not a prime\n");
        }

        private static void AddNextPrime()
        {
            var nextPrimeCalc = new PrimeCalculator();
            var nextPrime = nextPrimeCalc.NextPrime();
            Console.WriteLine($"Next prime was {nextPrime} and was added to the list");
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