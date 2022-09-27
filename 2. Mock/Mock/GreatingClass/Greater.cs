using Greating.Domain.Interfaces;
using System;

namespace Greating.Domain
{
    public class Greater
    {

        //injeta a dependencia externa

        private readonly ISystemTimeNow _systemTime;

        public Greater(ISystemTimeNow systemTime)
        {
            _systemTime = systemTime;
        }
        public string Greating()
        {
            var hour = _systemTime.GetDateTimeNow().Hour;

            if (hour<0 || hour >24)
            {
                throw new ArgumentOutOfRangeException("A hora deve estar em 0 e 24", nameof(hour));
            }
            if (hour is > 6 and <= 12)
            {
                return "BomDia";
            }
            if (hour is > 12 and <= 18)
            {
                return "BoaTarde";
            }

                return "Boa Noite";
            

        }
    }
}