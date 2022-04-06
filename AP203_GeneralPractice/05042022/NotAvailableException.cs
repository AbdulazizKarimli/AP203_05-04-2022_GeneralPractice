using System;
using System.Collections.Generic;
using System.Text;

namespace _05042022
{
    internal class NotAvailableException : Exception
    {
        public NotAvailableException(string message) : base(message)
        {
        }
    }
}
