namespace Uppgift1_LinusNestorson
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using Uppgift1_LinusNestorson.Helpers;

    /// <summary>
    /// Program class.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Entry point for program.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Menu();
        }

        /// <summary>
        /// Menu for user.
        /// </summary>
        private static void Menu()
        {
            Console.WriteLine("Welcome to the prime generator!");
            while (true)
            {
                try
                {
                    Console.WriteLine("\nChoose one of options below:");
                    Console.WriteLine("1. Check prime \n2. See list of added primes \n3. Add next prime to the list based on current higest number och primes \n4. Exit program\n");
                    Console.Write("> ");
                    int menuChoice = Convert.ToInt32(Console.ReadLine());

                    switch (menuChoice)
                    {
                        case 1:
                            Console.Clear();
                            ValidationCheck();
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
                            Console.WriteLine("Invalid input. Try again with one of the numbers in the menu\n");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nSomething went wrong with following error: {ex.Message}\n");
                }
            }
        }

        /// <summary>
        /// Method for validatiing input from user.
        /// </summary>
        /// <param name="choice">Input from user.</param>
        /// <returns>True or false</returns>
        private static bool InputValueCheck(int choice)
        {
            if (choice <= 0)
            {
                Console.WriteLine("\nThe value have to be above zero");
                return false;
            }
            else if (choice > int.MaxValue)
            {
                Console.WriteLine("The number is too high, try something lower");
                return false;
            }
            else return true;
        }

        /// <summary>
        /// Pass on input to prime number check if valid.
        /// </summary>
        private static void ValidationCheck()
        {
            Console.WriteLine("Please enter number you want to check: ");
            Console.Write("> ");
            var numberChoice = Convert.ToInt32(Console.ReadLine());
            var valueCheck = InputValueCheck(numberChoice);
            if (valueCheck)
            {
                PrimeCheck(numberChoice);
            }
            else
            {
                Console.WriteLine("Invalid input\n");
            }
        }

        /// <summary>
        /// Send valid input from user to prime calculator method.
        /// </summary>
        /// <param name="numberChoice">Valid input from user</param>
        private static void PrimeCheck(int numberChoice)
        {
            var primeCalc = new PrimeCalculator();

            var result = primeCalc.PrimeCalc(numberChoice);

            if (result)
            {
                Console.WriteLine($"\nNumber {numberChoice} is a prime and added to the list of primes.");
            }
            else Console.WriteLine("The number is not a prime\n");
        }

        /// <summary>
        /// Print message with the number added based on highest number in list.
        /// </summary>
        private static void AddNextPrime()
        {
            var nextPrimeCalc = new PrimeCalculator();
            var nextPrime = nextPrimeCalc.NextPrime();
            Console.WriteLine($"Next prime was {nextPrime} and was added to the list\n");
        }

        /// <summary>
        /// Display list of all logged prime numbers
        /// </summary>
        private static void SeeListOfPrimes()
        {
            Console.WriteLine("These are your logged primes:");

            if (PrimeHelper.primeList.Count > 0)
            {
                foreach (var primes in PrimeHelper.primeList)
                {
                    Console.WriteLine($"{primes}");
                }
            }
            else
            {
                Console.WriteLine("\nNo logged primes");
            }
        }
    }
}