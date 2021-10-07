namespace Uppgift1_LinusNestorson.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
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

        [TestCase(6)]
        [TestCase(20)]
        [TestCase(138)]
        [TestCase(289)]
        [TestCase(913)]
        [TestCase(6919)]
        [TestCase(102534)]
        [Test]
        public void PrimeCalculatorFalse(int numberTest)
        {
            var prime = new PrimeCalculator();
            var result = prime.PrimeCalc(numberTest);
            Assert.IsFalse(result);
        }
    }
}