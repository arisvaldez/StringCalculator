using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestClass]
    public class StringCalculatorShould
    {
        [TestMethod]
        public void Return0WhenReceivesEmpty()
        {
            var calculator = new StringCalculatorMethod();
            var result = calculator.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ReturnNumberWhenReceivesThatNumber()
        {
            var calculator = new StringCalculatorMethod();
            var result = calculator.Add("1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ReturnSumWhenReceivesTwoNumber()
        {
            var calculator = new StringCalculatorMethod();
            var result = calculator.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ReturnSumWhenReceivesAnyAmountOfNumber()
        {
            var calculator = new StringCalculatorMethod();
            var result = calculator.Add("1,2,4,5");
            Assert.AreEqual(12, result);
        }
    }
}
