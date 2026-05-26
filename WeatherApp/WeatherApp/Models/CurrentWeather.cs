using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class CurrentWeather
    {
        [JsonPropertyName("time")]
        public string? Time { get; set; }
        [JsonPropertyName("interval")]
        public int Interval { get; set; }

        [JsonPropertyName("temperature_2m")]
        public double Temperature2m { get; set; }

        public double Temperature2mF => (Temperature2m * 9 / 5) + 32;

        [JsonPropertyName("relative_humidity_2m")]
        public int RelativeHumidity2m { get; set; }

        [JsonPropertyName("apparent_temperature")]
        public double ApparentTemperature { get; set; }
        public double ApparentTemperatureF => (ApparentTemperature * 9 / 5) + 32;

        [JsonPropertyName("is_day")]
        public int IsDay { get; set; }

        [JsonPropertyName("rain")]
        public double Rain { get; set; }

        [JsonPropertyName("wind_speed_10m")]
        public double WindSpeed10m { get; set; }
        public double WindSpeedKm => WindSpeed10m * 3.6; 

        [JsonPropertyName("surface_pressure")]
        public double SurfacePressure { get; set; }

        [JsonPropertyName("pressure_msl")]
        public double Pressure { get; set; }

        [JsonPropertyName("wind_gusts_10m")]
        public double WindGusts { get; set; }
        public double WindGustsKm => WindGusts * 3.6;

        [JsonPropertyName("wind_direction_10m")]
        public double WindDirection { get; set; }

        public string GetFormattedTime()
        {
            return Convert.ToDateTime(Time).ToString("D");
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
