using System.Runtime.Serialization;

namespace CodeCompanion.Exceptions
{
    public class DataRequiredException<TExpected> : Exception
    {
        public DataRequiredException() : base($"Expecting an instance of type '{typeof(TExpected).FullName}'")
        {
        }

        public DataRequiredException(string? message) : base(message)
        {
        }

        public DataRequiredException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DataRequiredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}