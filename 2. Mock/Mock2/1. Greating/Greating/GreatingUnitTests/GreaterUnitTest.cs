using Greating.Domain;
using Shouldly;
using Moq;
namespace GreatingUnitTests
{
    public class GreaterUnitTest : MockSystemTime
    {
     

        [Fact] // com classeBase
        public void Greeting_Morning_ShouldReturnGoodMorning() 
        {
            var mock = GetTimeNowMock(7);
            var sut =  new Greater(mock);

            var actual = sut.Greeting();

            actual.ShouldBe("BomDia");
        }

        [Fact] //sem classe Base
        public void Greeting_Morning_ShouldReturnGoodMorningSimple()
        {
            var mock = new Mock<ISystemService>();

            mock.Setup(x => x.GetTimeNow())
                .Returns(new DateTime(2002, 02, 02, 07, 22, 50));

            var sut = new Greater(mock.Object);

            var actual = sut.Greeting();

            actual.ShouldBe("BomDia");
        }
    }
}