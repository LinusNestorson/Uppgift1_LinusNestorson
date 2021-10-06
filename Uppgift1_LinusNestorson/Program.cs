namespace Uppgift1_LinusNestorson
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the prime generator!\n");
            while (true)
            {
                Console.WriteLine("Choose one of options below:");
                Console.WriteLine("1. Check prime \n2. See list of added primes \n3. Exit program");
                int menuChoice = Convert.ToInt32(Console.ReadLine());
                if (menuChoice == 1)
                {
                    CheckIfPrime();
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
    }
}