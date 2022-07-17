using ABB_BF.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ABB_BF.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Probation> Probation { get; set; }
        public DbSet<ProbationFile> ProbationFile { get; set; }
        public DbSet<Grant> Grant { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<Practice> Practice { get; set; }
        public DbSet<PracticeFile> PracticeFile { get; set; }
        public DbSet<College> College { get; set; }
        public DbSet<EnumsToEntities> CourseDirections { get; set; }
        //public DbSet<EnumsToEntities> EducationForms { get; set; }
        //public DbSet<EnumsToEntities> EducationLevels { get; set; }
        //public DbSet<EnumsToEntities> Specialities { get; set; }



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
                builder.Property(x => x.StartDate)
                    .HasConversion<DateOnlyConverter, DateOnlyComparer>();
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
