using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tpte03.RazorPages.Data;
using tpte03.RazorPages.Models;

namespace tpte03.RazorPages.Pages.Feedback
{
    public class Delete : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public FeedbackModel FeedbackModel { get; set; } = new();

        public Delete(AppDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int id) {
            var feedbackToDelete = await _context.Feedbacks!.FindAsync(id);

            if (feedbackToDelete == null) {
                return NotFound();
            }

            try {
                _context.Feedbacks.Remove(feedbackToDelete);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Feedback/Index");
            } catch (DbUpdateException) {
                return Page();
            }
        }
    }
}