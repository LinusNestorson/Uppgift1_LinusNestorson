namespace Uppgift1_LinusNestorson.Tests
{
    using NUnit.Framework;
    using Uppgift1_LinusNestorson.Helpers;

    [TestFixture]
    public class Tests
    {
        //Testing if prime calculator handles prime numbers correct.
        [Test]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(19)]
        [TestCase(71)]
        [TestCase(139)]
        [TestCase(911)]
        [TestCase(7919)]
        [TestCase(103583)]
        public void PrimeCalculatorCorrect(int numberTest)
        {
            var prime = new PrimeCalculator();
            var result = prime.PrimeCalc(numberTest);
            Assert.IsTrue(result);
        }

        //Testing if prime calculator handles non-prime numbers correct.
        [Test]
        [TestCase(6)]
        [TestCase(20)]
        [TestCase(138)]
        [TestCase(289)]
        [TestCase(913)]
        [TestCase(6919)]
        [TestCase(102534)]
        public void PrimeCalculatorFalse(int numberTest)
        {
            var prime = new PrimeCalculator();
            var result = prime.PrimeCalc(numberTest);
            Assert.IsFalse(result);
        }

        //Testing functionality of next prime calculation with numbers in list.
        [Test]
        [TestCase(5, 11)]
        public void NextPrimeWithNum(int num1, int num2)
        {
            var prime = new PrimeCalculator();
            int expected = 13;
            PrimeHelper.primeList.Add(num1);
            PrimeHelper.primeList.Add(num2);
            var result = prime.NextPrime();
            Assert.AreEqual(result, expected);
        }

        //Testing functionality of next prime calculation without numbers in list.
        [Test]
        [TestCase(2)]
        public void NextPrimeEmpty(int num1)
        {
            var prime = new PrimeCalculator();
            int expected = num1;
            var result = prime.NextPrime();
            Assert.AreEqual(result, expected);
        }
    }
}