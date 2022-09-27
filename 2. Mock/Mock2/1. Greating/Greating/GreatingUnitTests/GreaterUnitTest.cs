using Greating.Domain;
using Shouldly;

namespace GreatingUnitTests
{
    public class GreaterUnitTest : MockSystemTime
    {
     

        [Fact]
        public void Greeting_Morning_ShouldReturnGoodMorning() 
        {
            var mock = GetTimeNowMock(7);
            var sut =  new Greater(mock);

            var actual = sut.Greeting();

            actual.ShouldBe("BomDia");
        }
    }
}