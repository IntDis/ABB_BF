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
        public DbSet<University> UniversityForms { get; set; }
        public DbSet<Practice> PracticeForms { get; set; }
        public DbSet<PracticeFile> PracticeFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grant>(builder =>
            {
                // Date is a DateOnly property and date on database
                builder.Property(x => x.CreationDate)
                    .HasConversion<DateOnlyConverter, DateOnlyComparer>();
            });
            modelBuilder.Entity<Probation>(builder =>
            {
                // Date is a DateOnly property and date on database
                builder.Property(x => x.CreationDate)
                    .HasConversion<DateOnlyConverter, DateOnlyComparer>();
            });
            modelBuilder.Entity<Practice>(builder =>
            {
                // Date is a DateOnly property and date on database
                builder.Property(x => x.CreationDate)
                    .HasConversion<DateOnlyConverter, DateOnlyComparer>();
            });
            modelBuilder.Entity<University>(builder =>
            {
                // Date is a DateOnly property and date on database
                builder.Property(x => x.CreationDate)
                    .HasConversion<DateOnlyConverter, DateOnlyComparer>();
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
