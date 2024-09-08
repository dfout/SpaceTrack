using Space_Track.Pages.Models;
namespace Space_Track.Pages.Services
{
    public interface IWeatherService
    {
        Task<WeatherData> GetWeatherDataAsync(string location);
    }
}