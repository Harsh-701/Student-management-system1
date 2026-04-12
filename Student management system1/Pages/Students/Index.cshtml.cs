using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_management_system1.Data;
using Student_management_system1.Models;

namespace Student_management_system1.Pages.Students
{
    public class StudentsIndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public StudentsIndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get; set; } 

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}
