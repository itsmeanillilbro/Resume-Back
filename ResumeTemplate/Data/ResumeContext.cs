using Microsoft.EntityFrameworkCore;
using ResumeAPI.Models;
using ResumeTemplate.Models;

namespace ResumeAPI.Data
{
    public class ResumeContext : DbContext
    {
        public ResumeContext(DbContextOptions<ResumeContext> options) : base(options) { }

        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
