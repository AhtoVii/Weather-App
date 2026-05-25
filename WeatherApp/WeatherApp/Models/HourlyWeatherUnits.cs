using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class HourlyWeatherUnits
    {
        [JsonPropertyName("time")]
        public string? Time { get; set; }

        [JsonPropertyName("temperature_2m")]
        public string? Temperature { get; set; }
        public string? TemperatureF { get; set; } = "°F";

        [JsonPropertyName("rain")]
        public string? Rain { get; set; }

        [JsonPropertyName("wind_speed_10m")]
        public string? WindSpeed { get; set; }
        public string? WindSpeedKm { get; set; } = "km/h";

        [JsonPropertyName("wind_direction_10m")]
        public string? WindDirection { get; set; }

        [JsonPropertyName("wind_gusts_10m")]
        public string? WindGusts { get; set; }
        public string? WindGustsKm { get; set; } = "km/h";

        [JsonPropertyName("relative_humidity_2m")]
        public string? Humidity { get; set; }

        [JsonPropertyName("pressure_msl")]
        public string? Pressure { get; set; }

        [JsonPropertyName("visibility")]
        public string? Visibility { get; set; }
        public string? VisibilityKm { get; set; } = "Km";

        [JsonPropertyName("apparent_temperature")]
        public string? ApparentTemperature { get; set; }
        public string? ApparentTemperatureF { get; set; } = "°F";

        [JsonPropertyName("surface_pressure")]
        public string? SurfacePressure { get; set; }

        [JsonPropertyName("uv_index")]
        public string? UvIndex { get; set; }

        [JsonPropertyName("dew_point_2m")]
        public string? DewPoint { get; set; }
        public string? DewPointF { get; set; } = "°F";

    }
}
