using System.Runtime.Serialization;
using System.Text;

namespace CodeCompanion.Exceptions
{
    public class EntityAlreadyExistsException : CodeCompanionException
    {
        public EntityAlreadyExistsException() { }

        public EntityAlreadyExistsException(string? message) : base(message) { }

        public EntityAlreadyExistsException(string? message, Exception? innerException) : base(message, innerException) { }

        protected EntityAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        protected override void SetClientMessage(StringBuilder builder) => builder.Append("Entity already exists");
    }
}