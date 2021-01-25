using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message) : base(message)
        {

        }
    }
}
