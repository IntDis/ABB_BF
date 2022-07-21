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
                });

            modelBuilder.Entity<CourseDirection>().HasData(
                new CourseDirection() { Id = 1, Number = 1, Definition = "Welcome тренинг" },
                new CourseDirection() { Id = 2, Number = 2, Definition = "Активные продажи по телефону ЮЛ" },
                new CourseDirection() { Id = 3, Number = 3, Definition = "Развитие управленческих навыков РОП" },
                new CourseDirection() { Id = 4, Number = 4, Definition = "Индивидуальный план развития" },
                new CourseDirection() { Id = 5, Number = 5, Definition = "Ситуационное руководство" },
                new CourseDirection() { Id = 6, Number = 6, Definition = "Контроль и обратная связь" },
                new CourseDirection() { Id = 7, Number = 7, Definition = "Мотивация и вовлечение" },
                new CourseDirection() { Id = 8, Number = 8, Definition = "Подбор, адаптация и развитие" },
                new CourseDirection() { Id = 9, Number = 9, Definition = "Постановка задач и делегирование" },
                new CourseDirection() { Id = 10, Number = 10, Definition = "Секреты управления командой" },
                new CourseDirection() { Id = 11, Number = 11, Definition = "Цикл менеджмента" },
                new CourseDirection() { Id = 12, Number = 12, Definition = "Развитие управленческих навыков РОП" },
                new CourseDirection() { Id = 13, Number = 13, Definition = "Деловая переписка" },
                new CourseDirection() { Id = 14, Number = 14, Definition = "PowerPoint.Деловая презентация и визуализация" },
                new CourseDirection() { Id = 15, Number = 15, Definition = "Управление конфликтными ситуациями" },
                new CourseDirection() { Id = 16, Number = 16, Definition = "Работа с возражениями" },
                new CourseDirection() { Id = 17, Number = 17, Definition = "Эффективные коммуникации" },
                new CourseDirection() { Id = 18, Number = 18, Definition = "Повышение личной эффективности" },
                new CourseDirection() { Id = 19, Number = 19, Definition = "Лидерство" },
                new CourseDirection() { Id = 20, Number = 20, Definition = "Жизнестойкость" },
                new CourseDirection() { Id = 21, Number = 21, Definition = "Наставнический стиль" },
                new CourseDirection() { Id = 22, Number = 22, Definition = "Стратегии и тактики в переговарах" },
                new CourseDirection() { Id = 23, Number = 23, Definition = "Публичные выступления" },
                new CourseDirection() { Id = 24, Number = 24, Definition = "Системное мышление" },
                new CourseDirection() { Id = 25, Number = 25, Definition = "Тайм - менеджмент" },
                new CourseDirection() { Id = 26, Number = 26, Definition = "Эмоциональный интеллект" },
                new CourseDirection() { Id = 27, Number = 27, Definition = "DISC.Типология личности" },
                new CourseDirection() { Id = 28, Number = 28, Definition = "Креативное мышление" },
                new CourseDirection() { Id = 29, Number = 29, Definition = "Когнитивная гибкость" },
                new CourseDirection() { Id = 30, Number = 30, Definition = "Развитие памяти" },
                new CourseDirection() { Id = 31, Number = 31, Definition = "Критическое мышление" },
                new CourseDirection() { Id = 32, Number = 32, Definition = "Обратная связь" },
                new CourseDirection() { Id = 33, Number = 33, Definition = "Кросс - культурное взаимодействие" },
                new CourseDirection() { Id = 34, Number = 34, Definition = "Лидеры переговоров" },
                new CourseDirection() { Id = 35, Number = 35, Definition = "Скетчинг" },
                new CourseDirection() { Id = 36, Number = 36, Definition = "Развитие памяти" },
                new CourseDirection() { Id = 37, Number = 37, Definition = "Microsoft Excel(мобильное обучение)" },
                new CourseDirection() { Id = 38, Number = 38, Definition = "Принятие решений в условии неопределенности и риска" },
                new CourseDirection() { Id = 39, Number = 39, Definition = "Инструменты фасилитации" },
                new CourseDirection() { Id = 40, Number = 40, Definition = "Позитивное мышление" },
                new CourseDirection() { Id = 41, Number = 41, Definition = "Microsoft Excel(Тренинг Спейс)" },
                new CourseDirection() { Id = 42, Number = 42, Definition = "Верификация лжи" },
                new CourseDirection() { Id = 43, Number = 43, Definition = "Ассертивное поведение" },
                new CourseDirection() { Id = 44, Number = 44, Definition = "Манипулятивная коммуникация" },
                new CourseDirection() { Id = 45, Number = 45, Definition = "Манипуляции и ложь в переговорах" },
                new CourseDirection() { Id = 46, Number = 46, Definition = "Хочу быть наставником" },
                new CourseDirection() { Id = 47, Number = 47, Definition = "Эффективные переговоры с лицом, принимающим решения" },
                new CourseDirection() { Id = 48, Number = 48, Definition = "Холодные звонки" },
                new CourseDirection() { Id = 49, Number = 49, Definition = "Кросс - продажи" },
                new CourseDirection() { Id = 50, Number = 50, Definition = "Кросс - продукты" },
                new CourseDirection() { Id = 51, Number = 51, Definition = "Продажи." },
                new CourseDirection() { Id = 52, Number = 52, Definition = "Школа персонального менеджмента" },
                new CourseDirection() { Id = 53, Number = 53, Definition = "Школа по обслуживанию клиента" },
                new CourseDirection() { Id = 54, Number = 54, Definition = "Повышение финансовой грамотности" }
                );

            modelBuilder.Entity<EducationLevel>().HasData(
                new EducationLevel()
                {
                    Id = 1,
                    Number = 1,
                    Definition = "Колледж/Техникум"
                },
                new EducationLevel()
                {
                    Id = 2,
                    Number = 2,
                    Definition = "Бакалавриат"
                },
                new EducationLevel()
                {
                    Id = 3,
                    Number = 3,
                    Definition = "Специалитет"
                },
                new EducationLevel()
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
