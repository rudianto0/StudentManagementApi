using Microsoft.EntityFrameworkCore;
using StudentManagementApi.Models.Domain;

namespace StudentManagementApi.Data
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<StudentGuardians> StudentGuardians { get; set; }
    }
}
