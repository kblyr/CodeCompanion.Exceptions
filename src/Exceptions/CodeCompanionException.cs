using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Text;

namespace CodeCompanion.Exceptions
{
    public class CodeCompanionException : Exception
    {
        public CodeCompanionException() { }

        public CodeCompanionException(string? message) : base(message) { }

        public CodeCompanionException(string? message, Exception? innerException) : base(message, innerException) { }

        protected CodeCompanionException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public string ClientMessage
        {
            get
            {
                var builder = new StringBuilder();
                SetClientMessage(builder);
                return builder.ToString();
            }
        }

        public IDictionary<string, object?> ErrorData
        {
            get
            {
                var errorData = new Dictionary<string, object?>();
                SetErrorData(errorData);
                return errorData;
            }
        }

        protected virtual void SetClientMessage(StringBuilder builder) { }

        protected virtual void SetErrorData(IDictionary<string, object?> errorData) { }
    }
}