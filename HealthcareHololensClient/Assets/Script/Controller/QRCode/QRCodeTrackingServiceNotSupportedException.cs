using System;
using System.Runtime.Serialization;

[Serializable]
internal class QRCodeTrackingServiceNotSupportedException : Exception
{
    public QRCodeTrackingServiceNotSupportedException()
    {
    }

    public QRCodeTrackingServiceNotSupportedException(string message) : base(message)
    {
    }
}