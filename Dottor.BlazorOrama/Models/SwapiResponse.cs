namespace Dottor.BlazorOrama.Models
{
    using System.Text.Json.Serialization;

    public class SwapiResponse<TItem>
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("results")]
        public IEnumerable<TItem>? Results { get; set; }
    }
}
