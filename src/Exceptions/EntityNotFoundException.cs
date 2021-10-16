using System.Runtime.Serialization;
using System.Text;

namespace CodeCompanion.Exceptions
{
    public class EntityNotFoundException : CodeCompanionException
    {
        public EntityNotFoundException() { }

        public EntityNotFoundException(string? message) : base(message) { }

        public EntityNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }

        protected EntityNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        protected override void SetClientMessage(StringBuilder builder) => builder.Append("Entity does not exists");
    }
}