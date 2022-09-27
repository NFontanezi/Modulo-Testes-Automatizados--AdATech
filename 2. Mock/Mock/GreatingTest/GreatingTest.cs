
using Greating.Domain;
using Greating.Domain.Interfaces;
//using Shouldly;
//using Moq;

namespace GreatingTest
{
    public class GreatingTest
    {
        private readonly ISystemTimeNow _systemTime = new SystemTimeTester();


        [Fact]
        public void GreatingMorning_ShouldReturnsBomDia()
        {
            const string expected = "BomDia";

            var sut = new Greater(_systemTime);

            string actual = (string)sut.Greating();

            bool result = (expected == actual);

            Assert.Equal(expected, actual);
           //Assert.True(result);

        }

        [Fact]
        public void GreatingMorning_ShouldReturnsBoaTarde()
        {
            const string expected = "BoaTarde";
            var sut = new Greater(_systemTime);

            string actual = (string)sut.Greating();

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void GreatingMorning_ShouldReturnsBoaNoite()
        {
            const string expected = "Boa Noite";
            var sut = new Greater(_systemTime);

            string actual = sut.Greating();

            Assert.Equal(expected, actual);

        }
    }
}
    /*

    [Theory]
    [InlineData(13)]
    [InlineData(15)]
    [InlineData(17)]

    public void GreatingeEvening_ShouldReturnsBoaTarde(int hour)
    {
        const string expected = "Boa Tarde";
        var sut = new Greater();

        string actual = sut.Greating(hour);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(19)]
    [InlineData(22)]
    [InlineData(0)]
    public void GreatingNight_ShouldReturnsBoaNoite(int hour)
    {
        const string expected = "Boa Noite";
        var sut = new Greater();

        string actual = sut.Greating(hour); 

        Assert.Equal(expected, actual); // actual.ShouldBe(expected) using Shouldly NAO FUNCIONA
    }
    */

