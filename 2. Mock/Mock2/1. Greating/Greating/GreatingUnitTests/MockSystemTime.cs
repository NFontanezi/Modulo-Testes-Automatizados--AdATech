

using Moq;
using Greating.Domain;

namespace GreatingUnitTests
{
    public class MockSystemTime
    {
        private readonly Mock<ISystemService> _serviceMock = new Mock<ISystemService>();

    

        public MockSystemTime()
        {


            _serviceMock.Setup(x=>x.GetTimeNow()).Returns
                (new DateTime(2002, 02, 02, 07, 22, 50));
        }

        public ISystemService GetTimeNowMock(int hour)
        {
            var mock = new Mock<ISystemService>();

            mock.Setup(x => x.GetTimeNow()).Returns
                (new DateTime(2022,09,27,hour,30,22));

 
            return mock.Object;
        }

        public ISystemService SystemTimeMock => _serviceMock.Object; // pra que serve?
    }
}
