using System.Text.Json.Serialization;

namespace TwitterAnalysis.App.Service.Model.Settings
{
    public class TwitterSettings
    {
        [JsonPropertyName("AccessToken")]
        public string AccessToken { get; set; }

        [JsonPropertyName("AccessTokenSecret")]
        public string AccessTokenSecret { get; set; }

        [JsonPropertyName("BearerToken")]
        public string BearerToken { get; set; }

        [JsonPropertyName("ConsumerKey")]
        public string ConsumerKey { get; set; }

        [JsonPropertyName("ConsumerSecret")]
        public string ConsumerSecret { get; set; }
    }
}
