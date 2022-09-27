
using Greating.Domain.Interfaces;

namespace GreatingTest
{
    public class SystemTimeTester : ISystemTimeNow // esse é o mock real
    {
        public DateTime GetDateTimeNow()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.Now.Day, 22, 22, 50);
        }
    }
}
