using System;
using System.Runtime.Serialization;

namespace AppFunctions
{
    [Serializable]
    internal class CrudOperationNotAvailableException : Exception
    {
        public CrudOperationNotAvailableException()
        {
        }

        public CrudOperationNotAvailableException(string message) : base(message)
        {
        }

        public CrudOperationNotAvailableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CrudOperationNotAvailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}