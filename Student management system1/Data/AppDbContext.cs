using Microsoft.EntityFrameworkCore;
using Student_management_system1.Models;

namespace Student_management_system1.Data
{
    public class AppDbContext:DbContext

    {
      public AppDbContext(DbContextOptions<AppDbContext>options)
            :base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        
    }
}
