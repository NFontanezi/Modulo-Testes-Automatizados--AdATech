using Letters.Domain;

namespace LettersUnitTest
{
    public class LettersUnitTests
    {
        [Fact]
        public void IsLetter_ShouldbeTrue()
        {
            string actual = "ana";

            var sut = new LettersClass();
            var result = sut.IsLetter(actual);

            Assert.True(result);

        }

        [Fact]
        public void IsLetter_ShouldbeFalse()
        {
            string actual = "carro";

            var sut = new LettersClass();
            var result = sut.IsLetter(actual);

            Assert.False(result);

        }
    }
}