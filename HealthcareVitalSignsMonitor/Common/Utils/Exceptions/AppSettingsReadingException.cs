using System;

namespace Common.Utils.Exceptions
{
    [Serializable]
    public class AppSettingsReadingException : Exception
    {
        public AppSettingsReadingException(string message, Exception e) : base(message, e)
        {

        }
    }
}