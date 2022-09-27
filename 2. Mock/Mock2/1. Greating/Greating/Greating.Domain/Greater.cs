using System.Linq;
namespace Greating.Domain
{
    public class Greater
    {
        readonly ISystemService _service;
       
        public Greater(ISystemService service)
        {
            _service = service;
        }

        public string Greeting()
        {
           int hour = _service.GetTimeNow().Hour;

            if (hour < 0 || hour > 24)
                throw new ArgumentOutOfRangeException("A hora deve estar entre 0 e 24", nameof(hour));

            if (hour is >= 6 and < 12)
                return "BomDia";

            if (hour is >= 12 and < 19)
                return "BoaTarde";

            return "BoaNoite";
        }
    }
}