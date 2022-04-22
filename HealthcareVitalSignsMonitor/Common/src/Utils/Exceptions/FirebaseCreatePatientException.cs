using System;

namespace Common.Utils.Exceptions
{
    [Serializable]
    public class FirebaseCreatePatientException : Exception
    {
        public FirebaseCreatePatientException(Exception e) : base("Cannot create patient of Firebase realtime database", e)
        {
        }
    }
}