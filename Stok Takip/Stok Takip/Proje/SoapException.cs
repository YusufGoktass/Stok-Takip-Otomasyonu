using System;
using System.Runtime.Serialization;

namespace Proje
{
    [Serializable]
    internal class SoapException : Exception
    {
        public SoapException()
        {
        }

        public SoapException(string message) : base(message)
        {
        }

        public SoapException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SoapException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}