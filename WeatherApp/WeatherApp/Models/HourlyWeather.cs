using System.Globalization;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class HourlyWeather
    {
        [JsonPropertyName("time")]
        public List<string>? Time { get; set; } = new();

        [JsonPropertyName("temperature_2m")]
        public List<double>? Temperature { get; set; } = new();

        [JsonPropertyName("rain")]
        public List<double>? Rain { get; set; } = new();

        [JsonPropertyName("wind_speed_10m")]
        public List<double> WindSpeed { get; set; } = new();

        [JsonPropertyName("wind_direction_10m")]
        public List<double> WindDirection { get; set; } = new();

        [JsonPropertyName("wind_gusts_10m")]
        public List<double> WindGusts { get; set; } = new();

        [JsonPropertyName("relative_humidity_2m")]
        public List<double> Humidity { get; set; } = new();

        [JsonPropertyName("pressure_msl")]
        public List<double> Pressure { get; set; } = new();

        [JsonPropertyName("visibility")]
        public List<double> Visibility { get; set; } = new();

        [JsonPropertyName("apparent_temperature")]
        public List<double> ApparentTemperature { get; set; } = new();

        [JsonPropertyName("surface_pressure")]
        public List<double> SurfacePressure { get; set; } = new();

        [JsonPropertyName("uv_index")]
        public List<double> UvIndex { get; set; } = new();

        [JsonPropertyName("dew_point_2m")]
        public List<double> DewPoint { get; set; } = new();

        public class HourlyTemperature
        {
            public string Time { get; set; } = "";
            public double Temperature { get; set; }
            public double TemperatureF => (Temperature * 9 / 5) + 32;
            public double Rain { get; set; }
            public double WindSpeed { get; set; }
            public double WindSpeedKm => WindSpeed * 3.6;
            public double WindDirection { get; set; }
            public double WindGusts { get; set; }
            public double WindGustsKm => WindGusts * 3.6;
            public double Humidity { get; set; }
            public double Pressure { get; set; }
            public double Visibility { get; set; }
            public double VisibilityKm => Visibility / 10;
            public double ApparentTemperature { get; set; }
            public double ApparentTemperatureF => (ApparentTemperature * 9 / 5) + 32;
            public double SurfacePressure { get; set; }
            public double UvIndex { get; set; }
            public double DewPoint { get; set; }
            public double DewPointF => (DewPoint * 9 / 5) + 32;

            public string GetHour()
            {
                if (string.IsNullOrEmpty(Time)) return "";
                return DateTime.Parse(Time, CultureInfo.InvariantCulture).ToString("t");
            }

            public Enums.WindDirection GetWindDirection()
            {
                return WindDirection switch
                {
                    >= 337.5 or < 22.5 => Enums.WindDirection.Pohjoistuuli,
                    >= 22.5 and < 67.5 => Enums.WindDirection.Koillistuuli,
                    >= 67.5 and < 112.5 => Enums.WindDirection.Itätuuli,
                    >= 112.5 and < 157.5 => Enums.WindDirection.Kaakkoistuuli,
                    >= 157.5 and < 202.5 => Enums.WindDirection.Etelätuuli,
                    >= 202.5 and < 247.5 => Enums.WindDirection.Lounaistuuli,
                    >= 247.5 and < 292.5 => Enums.WindDirection.Länsituuli,
                    >= 292.5 and < 337.5 => Enums.WindDirection.Luoteistuuli,
                    _ => throw new ArgumentOutOfRangeException(nameof(WindDirection), "Asteiden täytyy olla välillä 0-360.")
                };
            }
        }
    }
}
