using Greating.Domain.Interfaces;


namespace Greating.Domain
{
    public class SystemTime : ISystemTimeNow // amarrar no program sevices.AddTransient
    {
        public DateTime GetDateTimeNow() => DateTime.Now;



    }
}
