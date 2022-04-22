using System;

namespace Common.Utils.Exceptions
{
    [Serializable]
    public class IotDeviceCreationException : Exception
    {
        public IotDeviceCreationException(Exception e) : base("Cannot create iot device.", e)
        {
        }
    }
}