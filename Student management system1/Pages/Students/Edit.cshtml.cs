using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_management_system1.Data;
using Student_management_system1.Models;

namespace Student_management_system1.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;
        public EditModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Student Student { get; set; } 
        public async Task<IActionResult>OnGetAsync(int id)
        {
            Student = await _context.Students.FindAsync(id);
            if (Student == null)
                return NotFound();
            return Page();
        }
        public async Task<IActionResult>OnPostAsync()
        {
            _context.Attach(Student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");

        }

    }
}
