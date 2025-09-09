using System.ComponentModel;
using System.Text.Json.Serialization;
using Microsoft.OpenApi;

namespace TwitterAnalysis.Infrastructure.Utils
{
    public class Messages
    {
        [JsonPropertyName("code")]
        public ErrorCodes Code { get; }

        private string _message { get; set; }

        [JsonPropertyName("message")]
        public string Message { get => string.IsNullOrEmpty(_message) ? Code.GetAttributeOfType<DescriptionAttribute>().Description : _message; set => _message = value; }

        [JsonPropertyName("fields")]
        public List<MessageDetail> Fields { get; private set; }

        public Messages(ErrorCodes code)
        {
            Code = code;
        }

        public Messages(ErrorCodes code, MessageDetail field)
        {
            Code = code;
            Fields = [field];
        }

        public Messages(ErrorCodes code, string message, MessageDetail field)
        {
            Code = code;
            Message = message;
            Fields =
            [
                field
            ];
        }

        public Messages(ErrorCodes code, List<MessageDetail> fields)
        {
            Code = code;
            Fields = fields;
        }

        public Messages(ErrorCodes code, string message, List<MessageDetail> fields)
        {
            Code = code;
            Message = message;
            Fields = fields;
        }
    }
}
