
using System.Text.Json.Serialization;
using TwitterAnalysis.Infrastructure.Utils.Interfaces;

namespace TwitterAnalysis.Infrastructure.Utils
{
    public class FailedOperation : IOperation
    {
        public FailedOperation(ErrorCodes code) 
        {
            Messages = new Messages(code);
        }

        public FailedOperation(Messages messages)
        {
            Messages = messages;
        }

        public FailedOperation(ErrorCodes code, MessageDetail messageDetail)
        {
            Messages = new Messages(code, messageDetail);
        }

        public FailedOperation(ErrorCodes code, List<MessageDetail> messageDetail)
        {
            Messages = new Messages(code, messageDetail);
        }


        [JsonPropertyName("messages")]
        public Messages Messages { get; }
    }

    public class FailedOperation<T> : FailedOperation, IOperation<T>
    {
        [JsonPropertyName("data")]
        public T Data { get; }


        public FailedOperation(ErrorCodes code) : base(code) { }

        public FailedOperation(ErrorCodes code, T value) : base(code) => Data = value;  

        public FailedOperation(ErrorCodes code, MessageDetail messageDetail) : base(code, messageDetail)
        {
        }

        public FailedOperation(ErrorCodes code, List<MessageDetail> messageDetail) : base(code, messageDetail)
        {
        }
    }
}
