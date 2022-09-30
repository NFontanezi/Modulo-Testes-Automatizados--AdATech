using AdaCalculator;
using Moq;
using Shouldly;

namespace AdaCalculatorTest
{
    public class AdaCalculatorUnitTestWithMock
    {
        private Mock<ICalculator> mock;
        public AdaCalculatorUnitTestWithMock()
        {
            mock = new Mock<ICalculator>();
        }


        //METODOS WITH MOCK

        [Fact]
        public void Calculate_SUM_ReturnsSumWithMock()
        {
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>()))
            .Returns(("sum", 8));

            var sut = new CalculatorMachine(mock.Object);

            var result = sut.Calculate("sum", 4, 4);

            mock.Verify(x => x.Calculate("sum", 4, 4));

        }

        [Fact]
        public void Calculate_Multiply_ReturnsMultiplyWithMock()
        {
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>()))
            .Returns(("multiply", 8));

            var sut = new CalculatorMachine(mock.Object);

            var result = sut.Calculate("multiply", 4, 2);

            mock.Verify(x => x.Calculate("multiply", 4, 2));

        }

        [Fact]
        public void Calculate_Substract_ReturnsSubstractyWithMock()
        {
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>()))
            .Returns(("subtract", 8));

            var sut = new CalculatorMachine(mock.Object);

            var result = sut.Calculate("subtract", 16, 8);

            mock.Verify(x => x.Calculate("subtract", 16, 8));

        }

        [Fact]
        public void Calculate_Divide_ReturnsDivideyWithMock()
        {
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>()))
            .Returns(("divide", 4));

            var sut = new CalculatorMachine(mock.Object);

            var result = sut.Calculate("divide", 4, 2);

            mock.Verify(x => x.Calculate("divide", 4, 2));

        }


    }
}
