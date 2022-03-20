using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException : Exception
    {
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_NAME,
            INVALID_RIDE,
            INVALID_USER_ID,
            INVALID_TIME,
            NULL_RIDES,
        }

        ExceptionType Type;

        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
