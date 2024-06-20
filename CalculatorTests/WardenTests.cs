using Calculator.Menu;

namespace CalculatorTests
{
    [TestClass]
    public class WardenTests
    {
        [TestMethod]
        public void Divide()
        {
            string start = "1/5";
            Warden.Observe(start);
            string expected = "0,2";
            Assert.AreEqual(expected, Warden.Observe(start));
        }

        [TestMethod]
        public void Multiply()
        {
            string start = "5*6";
            string expected = "30";
            Assert.AreEqual(expected, Warden.Observe(start));
        }

        [TestMethod]
        public void Exponentiation()
        {
            string start = "2^3";
            string expected = "8";
            Assert.AreEqual(expected, Warden.Observe(start));
        }

        [TestMethod]
        public void Plus()
        {
            string start = "2+6";
            string expected = "8";
            Assert.AreEqual(expected, Warden.Observe(start));
        }

        [TestMethod]
        public void Minus()
        {
            string start = "6-7";
            string expected = "-1";
            Assert.AreEqual(expected, Warden.Observe(start));
        }

        [TestMethod]
        public void Brackets()
        {
            string start = "-(7*7)*2-3*0";
            string expected = "-98";
            Assert.AreEqual(expected, Warden.Observe(start));
        }
    }
}