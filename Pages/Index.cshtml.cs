using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Space_Track.Pages;


public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        
        
    }
    public string SearchTerm { get; set; }
    public IActionResult OnPostSearch(string searchTerm)
    {
        // Implement your search logic here using searchTerm
        // ... (return a view or redirect as needed)
        return Page();
    }
    
  
    public void OnGet()
    {

    }
}
