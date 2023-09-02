using Microsoft.AspNetCore.Mvc.RazorPages;
using tpte03.RazorPages.Data;

namespace tpte03.RazorPages.Pages.Feedback
{
    public class Index : PageModel
    {
        private readonly AppDbContext _context;
        public Index(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }
    }
}