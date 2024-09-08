using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Space_Track.Pages.Models
{
    public class WeatherData :PageModel
    {
        public string Name { get; set; }
        public double Temperature { get; set; }
        // Add other properties as needed
    }
}