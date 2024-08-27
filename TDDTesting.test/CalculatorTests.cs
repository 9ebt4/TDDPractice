using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_testing;

namespace TDDTesting.test
{
    public class CalculatorTests
    {
        [Fact]
        public void Addition_ReturnsCorrectSum()
        {
            var calculator = new Calculator();
            var result = calculator.Add(2, 3);
            Assert.Equal(5, result);
        }
        [Fact]
        public void Subtraction_ReturnCorrectDifference()
        {
            var calculator = new Calculator();
            var result = calculator.Subtract(2, 3);
            Assert.Equal(-1, result);
        }
        [Fact]
        public void Multiplication_ReturnCorrectProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(2, 3);
            Assert.Equal(6, result);
        }
        [Fact]
        public void Divider_ReturnCorrectQuotient()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(3, 3);
            Assert.Equal(1, result);
        }
    }
}
