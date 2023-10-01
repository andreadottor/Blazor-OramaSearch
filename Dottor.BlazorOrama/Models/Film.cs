namespace Dottor.BlazorOrama.Models
{
    using System.Text.Json.Serialization;

    public class Film
    {
		[JsonPropertyName("title")]
        public string Title { get; set; } = default!;
		[JsonPropertyName("episode_id")]
        public int EpisodeId { get; set; } = default!;
		[JsonPropertyName("opening_crawl")]
        public string OpeningCrawl { get; set; } = default!;
		[JsonPropertyName("director")]
        public string Director { get; set; } = default!;
		[JsonPropertyName("producer")]
        public string Producer { get; set; } = default!;
		[JsonPropertyName("release_date")]
        public DateTime ReleaseDate { get; set; } = default!;

    }
}
