using System;

namespace Common.Utils.Exceptions
{
    [Serializable]
    public class ClientAuthenticationException : Exception
    {
        public ClientAuthenticationException(Exception e) : base("Cannot authenticate digital twins client.", e)
        {

        }
    }
}