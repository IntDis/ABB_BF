using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Entities.EnumsToEntities;
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
        public DbSet<CourseDirection> CourseDirections { get; set; }
        public DbSet<EducationForm> EducationForms { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<Speciality> Specialities { get; set; }



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

            modelBuilder.Entity<EducationForm>().HasData(
                new EducationForm()
                {
                    Id = 1,
                    Number = 1,
                    Definition = "Очная"
                },
                new EducationForm()
                {
                    Id = 2,
                    Number = 2,
                    Definition = "Заочная"
                },
                new EducationForm()
                {
                    Id = 3,
                    Number = 3,
                    Definition = "Очно-заочная"
                }
            );

            modelBuilder.Entity<EducationForm>().HasData(
                new EducationForm()
                {
                    Id = 1,
                    Number = 1,
                    Definition = "Колледж/Техникум"
                },
                new EducationForm()
                {
                    Id = 2,
                    Number = 2,
                    Definition = "Бакалавриат"
                },
                new EducationForm()
                {
                    Id = 3,
                    Number = 3,
                    Definition = "Специалитет"
                },
                new EducationForm()
                {
                    Id = 4,
                    Number = 4,
                    Definition = "Магистратура"
                }
            );

            modelBuilder.Entity<Speciality>().HasData(
                new EducationForm()
                {
                    Id = 1,
                    Number = 1,
                    Definition = "экономика"
                },
                new EducationForm()
                {
                    Id = 2,
                    Number = 2,
                    Definition = "банковское дело"
                },
                new EducationForm()
                {
                    Id = 3,
                    Number = 3,
                    Definition = "кредиты и финансы"
                },
                new EducationForm()
                {
                    Id = 4,
                    Number = 4,
                    Definition = "рынок ценных бумаг"
                },
                new EducationForm()
                {
                    Id = 5,
                    Number = 5,
                    Definition = "информационные технологии"
                },
                new EducationForm()
                {
                    Id = 6,
                    Number = 6,
                    Definition = "бизнес-информатика"
                },
                new EducationForm()
                {
                    Id = 7,
                    Number = 7,
                    Definition = "бизнес-аналитика"
                },
                new EducationForm()
                {
                    Id = 8,
                    Number = 8,
                    Definition = "финансовый менеджмент"
                },
                new EducationForm()
                {
                    Id = 9,
                    Number = 9,
                    Definition = "информационная безопасность"
                },
                new EducationForm()
                {
                    Id = 10,
                    Number = 10,
                    Definition = "математическое моделирование (прикладная математика)"
                }
            );

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }


    }
}
