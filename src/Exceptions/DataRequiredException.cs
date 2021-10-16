using System.Runtime.Serialization;
using System.Text;

namespace CodeCompanion.Exceptions
{
    public class DataRequiredException : CodeCompanionException
    {
        public Type? ExpectedType { get; init; }
        public string? AdditionalMessage { get; init; }

        public DataRequiredException()
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

        protected override void SetClientMessage(StringBuilder builder)
        {
            if (AdditionalMessage is not null)
                builder.AppendLine(AdditionalMessage);
        }

        protected override void SetErrorData(IDictionary<string, object?> errorData)
        {
            if (ExpectedType is not null)
                errorData.Add(nameof(ExpectedType), ExpectedType.Name);
        }
    }
}