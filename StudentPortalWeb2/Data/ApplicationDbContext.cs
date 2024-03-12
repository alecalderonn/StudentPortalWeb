using Microsoft.EntityFrameworkCore;
using StudentPortalWeb2.Models.Entities;

namespace StudentPortalWeb2.Data
{
    public class ApplicationDbContext:DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Student> Students { get; set; } // colecion o table de estudiantes por asi llamarlo 
    }

}
    

