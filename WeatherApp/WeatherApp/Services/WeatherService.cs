using System.Globalization;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient _client;

        public WeatherService(HttpClient httpClient) => _client = httpClient;

        public async Task<WeatherReport?> GetCurrentWeatherAsync(double lat, double lon, DateTime? date = null)
        {
            var targetDate = date ?? DateTime.Today;
            var dateStr = targetDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            var url = $"https://api.open-meteo.com/v1/forecast" +
                      $"?latitude={lat.ToString(CultureInfo.InvariantCulture)}&longitude={lon.ToString(CultureInfo.InvariantCulture)}" +
                      $"&current=temperature_2m,relative_humidity_2m,apparent_temperature,is_day,rain,wind_speed_10m,showers,snowfall,weather_code," +
                      $"cloud_cover,pressure_msl,surface_pressure,wind_direction_10m,wind_gusts_10m,precipitation&wind_speed_unit=ms" +
                      $"&hourly=temperature_2m,rain,wind_speed_10m,wind_direction_10m,wind_gusts_10m,relative_humidity_2m,pressure_msl,visibility," +
                      $"apparent_temperature,surface_pressure,uv_index,dew_point_2m" +
                      $"&start_date={dateStr}&end_date={dateStr}";

            return await _client.GetFromJsonAsync<WeatherReport>(url);
        }
    }
}
