using System.Text.Json.Serialization;

namespace TwitterAnalysis.Infrastructure.Utils
{
    public class MessageDetail
    {
        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }   
    }
}
