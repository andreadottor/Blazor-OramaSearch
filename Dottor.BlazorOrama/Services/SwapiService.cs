namespace Dottor.BlazorOrama.Services
{
    using Dottor.BlazorOrama.Models;
    using System.Text.Json;

    public class SwapiService
    {
        private readonly HttpClient _httpClient;

        public SwapiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IEnumerable<Film>> GetFilmsAsync()
        {
            var response = await _httpClient.GetAsync("https://swapi.dev/api/films");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<SwapiResponse<Film>>(content);
                return data.Results!;
            }
            
            return Enumerable.Empty<Film>();
        }
    }
}
