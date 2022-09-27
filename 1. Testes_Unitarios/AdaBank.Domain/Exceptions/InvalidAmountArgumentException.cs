using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaBank.Domain.Exceptions
{
    public class InvalidAmountArgumentException : ArgumentException
    {
        public InvalidAmountArgumentException()
        {
        }

        public InvalidAmountArgumentException(string message)
            : base(message)
        {
        }

        public InvalidAmountArgumentException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public InvalidAmountArgumentException(string? message, string? paramName)
            : base(message, paramName)
        {
        }
    }
}
