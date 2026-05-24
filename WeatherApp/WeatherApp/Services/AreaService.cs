using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class AreaService
    {
        private readonly HttpClient _client;

        public AreaService(HttpClient httpClient) => _client = httpClient;

        public async Task<List<Area>> GetAreasAsync()
        {
            var response = await _client.GetFromJsonAsync<AreaResponse>("data.json");
            return response?.Areas ?? new List<Area>();
        }
    }
}
