using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_management_system1.Data;
using Student_management_system1.Models;

namespace Student_management_system1.Pages.Students
{
    public class StudentsCreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public StudentsCreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; } 

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
