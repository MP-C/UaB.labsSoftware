using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DonativosWindowsForms
{
    public class ExceptionDonativos : FormatException
    {
        public ExceptionDonativos()
        {

        }

        public ExceptionDonativos(string message) : base(message)
        {

        }

        public ExceptionDonativos(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected ExceptionDonativos(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
