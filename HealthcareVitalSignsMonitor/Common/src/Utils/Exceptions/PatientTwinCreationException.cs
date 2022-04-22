using System;
using Azure;

namespace Common.Utils.Exceptions
{
    [Serializable]
    public class PatientTwinCreationException : Exception
    {
        public PatientTwinCreationException(Exception exception) : base("Unable to create patient", exception)
        {
        }
    }
}