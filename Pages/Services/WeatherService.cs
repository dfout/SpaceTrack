using System.Net.Http;
using Space_Track.Pages.Models;
using System.Text.Json;

namespace Space_Track.Pages.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<WeatherData> GetWeatherDataAsync(string location)
        {
            // var apiKey = "YOUR_API_KEY"; // Replace with your actual API key
            // var url = $"https://api.openweathermap.org/data/2.5/weather?q={location}&appid={apiKey}&units=metric";
            var url =$"https://google.com";
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                // var weatherData = await response.Content.ReadAsAsync<WeatherData>();
                var weatherData={temp:2 }
                return weatherData;
            }

            throw new Exception("Failed to fetch weather data.");
        }
    }
}