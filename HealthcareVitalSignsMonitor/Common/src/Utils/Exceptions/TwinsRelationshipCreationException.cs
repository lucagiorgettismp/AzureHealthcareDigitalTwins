using System;

namespace Common.Utils.Exceptions
{
    [Serializable]
    public class TwinsRelationshipCreationException : Exception
    {
        public TwinsRelationshipCreationException(Exception e) : base("Cannot create relation between twins.", e)
        {
        }
    }
}