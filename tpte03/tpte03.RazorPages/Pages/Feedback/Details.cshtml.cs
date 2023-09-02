using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tpte03.RazorPages.Data;
using tpte03.RazorPages.Models;

namespace tpte03.RazorPages.Pages.Feedback
{
    public class Details : PageModel
    {
        private readonly AppDbContext _context;
        public FeedbackModel FeedbackModel { get; set; } = new();

        public Details(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Feedbacks == null) {
                return NotFound();
            }

            var feedbackModel = await _context.Feedbacks.FirstOrDefaultAsync(feedback => feedback.IdFeedback == id);

            if (feedbackModel == null) {
                return NotFound();
            }

            FeedbackModel = feedbackModel;

            return Page();
        }
    }
}