using System;

namespace Common.Utils.Exceptions
{
    [Serializable]
    public class DevicesRetrievingException : Exception
    {
        public DevicesRetrievingException(Exception e) : base("Cannot get devices from iot hub.", e)
        {
        }
    }
}