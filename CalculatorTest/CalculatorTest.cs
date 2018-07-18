using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorTest
    {
        // step 1 -  // calculator.should_add_two_Number
        // step 2 -  // calculator.should_subtract_two_Number
        // step 3 -  // calculator.should_muliple_two_Number
        // step 4 -  // calculator.should_divide_two_Number

        [TestCase(5, 3, 8)]
        [TestCase(9, 3, 12)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -3, -5)]
        public void should_add_two_Number(int x, int y, int result)
        {
            // Act
            var calculator = new Calculator.Calculator();
            // arrange
            var sut = calculator.Add(x,y);
            //assert
            Assert.AreEqual(sut, result);
            Assert.GreaterOrEqual(x, y);
        }

        [Test]
        public void should_subtract_two_Number()
        {
            // Act
            var calculator = new Calculator.Calculator();
            // arrange
            var sut = calculator.Subtract(7, 3);
            //assert
            Assert.AreEqual(sut, 4);
        }

        [TestCase(5, 3, 15)]
        [TestCase(9, 3, 27)]
        [TestCase(-2, -3, 6)]
        public void should_multiply_two_Number(int x, int y, int result)
        {
            // Act
            var calculator = new Calculator.Calculator();
            // arrange
            var sut = calculator.Multiply(x, y);  // 15
            //assert
            Assert.AreEqual(sut, result);
        }
        
        [TestCase(12,3,4)]
        [TestCase(9,3,3)]
        [TestCase(12,2,6)]
        [TestCase(2,3,0)]
        public void should_division_two_Number(int x, int y, int result)
        {
            // Act
            var calculator = new Calculator.Calculator();
            // arrange
            var sut = calculator.Divide(x, y);
            //assert
            Assert.AreEqual(sut, result);
        }
    }
}
