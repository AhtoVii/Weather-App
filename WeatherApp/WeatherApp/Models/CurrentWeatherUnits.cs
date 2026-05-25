using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class CurrentWeatherUnits
    {
        [JsonPropertyName("time")]
        public string? Time { get; set; }

        [JsonPropertyName("interval")]
        public string? Interval { get; set; }

        [JsonPropertyName("temperature_2m")]
        public string? Temperature2m { get; set; }
        public string? Temperature2mF = "°F";

        [JsonPropertyName("relative_humidity_2m")]
        public string? RelativeHumidity2m { get; set; }

        [JsonPropertyName("apparent_temperature")]
        public string? ApparentTemperature { get; set; }
        public string? ApparentTemperatureF = "°F";

        [JsonPropertyName("is_day")]
        public string? IsDay { get; set; }

        [JsonPropertyName("rain")]
        public string? Rain { get; set; }

        [JsonPropertyName("wind_speed_10m")]
        public string? WindSpeed10m { get; set; }
        public string? WindSpeedKm { get; set; } = "km/h";

        [JsonPropertyName("surface_pressure")]
        public string? SurfacePressure { get; set; }

        [JsonPropertyName("pressure_msl")]
        public string? Pressure { get; set; }

        [JsonPropertyName("wind_gusts_10m")]
        public string? WindGusts { get; set; }
        public string? WindGustsKm { get; set; } = "km/h";

        [JsonPropertyName("wind_direction_10m")]
        public string? WindDirection { get; set; }
    }
}
