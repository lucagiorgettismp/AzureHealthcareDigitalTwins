using System;

namespace Common.Utils.Exceptions
{
    public class ConnectionStringException : Exception
    {
        public ConnectionStringException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}