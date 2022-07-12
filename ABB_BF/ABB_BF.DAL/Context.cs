using ABB_BF.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ABB_BF.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Probation> ProbationForms { get; set; }
        public DbSet<ProbationFile> ProbationFiles { get; set; }
        public DbSet<Grant> GrantForms { get; set; }
        public DbSet<GrantFiles> GrantFiles { get; set; }
        public DbSet<University> UniversityForms { get; set; }
        public DbSet<UniversityFile> UniversityFiles { get; set; }
        public DbSet<Practice> PracticeForms { get; set; }
        public DbSet<PracticeFile> PracticeFiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
