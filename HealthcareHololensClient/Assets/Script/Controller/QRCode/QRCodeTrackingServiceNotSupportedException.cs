using System;

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