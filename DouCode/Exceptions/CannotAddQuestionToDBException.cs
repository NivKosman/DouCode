using System;
using System.Runtime.Serialization;

namespace DouCode
{
    [Serializable]
    internal class CannotAddQuestionToDBException : Exception
    {
        public CannotAddQuestionToDBException()
        {
        }

        public CannotAddQuestionToDBException(string message) : base(message)
        {
        }

        public CannotAddQuestionToDBException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CannotAddQuestionToDBException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}