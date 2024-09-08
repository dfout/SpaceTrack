using Microsoft.AspNetCore.Mvc;
using Space_Track.Pages.Models;
using Space_Track.Pages.Services;

namespace Space_Track.Pages.Controllers
{
    public class SearchController : Controller
    {
        private readonly IWeatherService _weatherService;

        public SearchController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(string searchTerm)
        {
            var weatherData = await _weatherService.GetWeatherDataAsync(searchTerm);
            ViewBag.WeatherData = weatherData;
            return View();
        }
    }
}