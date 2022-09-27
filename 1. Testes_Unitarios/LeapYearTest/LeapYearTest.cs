
using LeapYear.Domain2;
namespace LeapYearTest
{
    public class LeapYearTest
    {
        [Theory]
        [InlineData(1988)]
        [InlineData(1992)]
        [InlineData(2004)]
        [InlineData(2024)]
        public async Task IsLeap_DivisibleBy4AndNotDivisibleBy100_ReturnsTrue(int year)
        {// async void = fire & forget
         //task signica q é um void assincrono e saberemos o retorno

            var sut = new LeapYearClass();

            var result = await sut.IsLeap(year);

            Assert.True(result);

        }

        [Theory]
        [InlineData(1999)]
        [InlineData(2001)]
        [InlineData(2003)]
       
        public async Task IsLeap_DivisibleBy4AndNotDivisibleBy100_ReturnsFalse(int year)
        {// async void = fire & forget
         //task signica q é um void assincrono e saberemos o retorno

            var sut = new LeapYearClass();

            var result = await sut.IsLeap(year);

            Assert.True(result);

        }
    }
}