using PrimeNumber.Domain;

namespace PrimeUnitTest
{
    public class PrimeTest
    {
        [Theory]
        [InlineData (0)]
        [InlineData (1)]
        public void IsPrime_ForLowerThan2_ShouldBeFalse(int number)
        {
            var sut = new IsPrime();


            bool result = sut.IsPrimeNumber(number);


            Assert.False(result);

        }

        [Theory] // normalmente faz 2 testes para retornos diferentes
        [InlineData(5, true)]
        [InlineData(10, false)]
        public void PrimeEvaluation_ResultShouldBeExpected(int number, bool expected)
        {
            var sut = new IsPrime();


            bool result = sut.IsPrimeNumber(number);


            Assert.Equal(expected,result);

        }


    }
}