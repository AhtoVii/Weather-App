using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class AreaResponse
    {
        [JsonPropertyName("municipalities")]
        public List<Area> Areas { get; set; } = new();
    }
}
