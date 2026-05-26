using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class DailyWeather
    {
        [JsonPropertyName("time")]
        public List<string>? Time { get; set; } = new();

        [JsonPropertyName("sunrise")]
        public List<string>? Sunrise { get; set; } = new();

        [JsonPropertyName("sunset")]
        public List<string>? Sunset { get; set; } = new();
    }

    public class DailyTemperature
    {
        public string? Time { get; set; }
        public string? Sunrise { get; set; }
        public string? Sunset { get; set; }
    }
}
