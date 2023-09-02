using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tpte03.RazorPages.Data;
using tpte03.RazorPages.Models;

namespace tpte03.RazorPages.Pages.Feedback
{
    public class Index : PageModel
    {
        private readonly AppDbContext _context;
        public List<FeedbackModel> FeedbackList { get; set; } = new();

        public Index(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            FeedbackList = await _context.Feedbacks!.ToListAsync();
            return Page();
        }
    }
}