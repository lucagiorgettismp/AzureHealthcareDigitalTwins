using System;

namespace AppFunctions
{
    [Serializable]
    internal class CrudOperationNotAvailableException : Exception
    {
        public CrudOperationNotAvailableException()
        {
        }
    }
}