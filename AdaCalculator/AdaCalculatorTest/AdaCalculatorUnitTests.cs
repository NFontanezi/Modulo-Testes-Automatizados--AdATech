
using AdaCalculator;

namespace AdaCalculatorTest
{
    public class AdaCalculatorUnitTests
    {

        private readonly Calculator sut;

        private readonly ICalculator sutMock;

        public AdaCalculatorUnitTests()
        {
            sut = new();
        }




        //METODOS WITHOUT MOCK

        [Theory]
        [InlineData( "sum", 1 , 4)]
        public void Calculate_SUM_ReturnsSum(string op, double a, double b)
        {
            var result = sut.Calculate(op, a, b);
            (string result, double c) expected = (op, (a+b));

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("multiply", 1, 4)]
        public void Calculate_Multiply_ReturnsMultiply(string op, double a, double b)
        {
            var result = sut.Calculate(op, a, b);
            (string result, double c) expected = (op, (a * b));

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("subtract", 1, 4)]
        public void Calculate_Subtract_ReturnsSubtract(string op, double a, double b)
        {
            var result = sut.Calculate(op, a, b);
            (string result, double c) expected = (op, (a - b));

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("divide", 1, 4)]
        public void Calculate_Divide_ReturnsDivide(string op, double a, double b)
        {
            var result = sut.Calculate(op, a, b);
            (string result, double c) expected = (op, (a / b));

            Assert.Equal(expected, result);
        }
    }
}