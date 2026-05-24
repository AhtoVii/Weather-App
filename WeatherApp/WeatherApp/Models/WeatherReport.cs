using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class WeatherReport
    {
        [JsonPropertyName("current")]
        public CurrentWeather? Current { get; set; } = new();

        [JsonPropertyName("current_units")]
        public CurrentWeatherUnits CurrentUnits { get; set; } = new();

        [JsonPropertyName("hourly")]
        public HourlyWeather Hourly { get; set; } = new();

        [JsonPropertyName("hourly_units")]
        public HourlyWeatherUnits HourlyUnits { get; set; } = new();

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("generationtime_ms")]
        public double GenerationTimeMs { get; set; }

        [JsonPropertyName("utc_offset_seconds")]
        public int UtcOffsetSeconds { get; set; }

        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        [JsonPropertyName("timezone_abbreviation")]
        public string? TimezoneAbbreviation { get; set; }

        [JsonPropertyName("elevation")]
        public double Elevation { get; set; }

    }
}
