using Microsoft.EntityFrameworkCore;
using StudentCRUD.Web.Models;

namespace StudentCRUD.Web.StudentDBContext
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
