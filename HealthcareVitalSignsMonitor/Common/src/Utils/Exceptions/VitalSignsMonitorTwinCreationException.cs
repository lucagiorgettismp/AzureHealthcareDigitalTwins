using System;

namespace Common.Utils.Exceptions
{
    [Serializable]
    public class VitalSignsMonitorTwinCreationException : Exception
    {
        public VitalSignsMonitorTwinCreationException(Exception e) : base("Cannot create vital signs monitor.", e)
        {

        }
    }
}