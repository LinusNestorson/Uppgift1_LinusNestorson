namespace Uppgift1_LinusNestorson.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(5)]
        [TestCase(433)]
        [TestCase(466)]
        [TestCase(467)]
        [TestCase(289)]
        [TestCase(919)]
        [TestCase(15269)]
        [TestCase(106366)]
        [TestCase(106367)]
        public void PrimeCalculator(int numberTest)
        {
            var prime = new PrimeCalculator();
            var result = prime.PrimeCalc(numberTest);
            Assert.IsTrue(result);
        }
    }
}