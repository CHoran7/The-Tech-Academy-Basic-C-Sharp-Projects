using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step165
{
    public class ZeroAgeException : Exception
    {
        public ZeroAgeException()
            : base() { }
        public ZeroAgeException(string message)
            : base(message) { }
    }
}
