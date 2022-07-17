﻿// <auto-generated />
using System;
using ABB_BF.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ABB_BF.DAL.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ABB_BF.DAL.Entities.College", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("College");
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.EnumsToEntities.CourseDirection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CourseDirections");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Welcome тренинг",
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Активные продажи по телефону ЮЛ",
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            Definition = "Развитие управленческих навыков РОП",
                            Number = 3
                        },
                        new
                        {
                            Id = 4,
                            Definition = "Индивидуальный план развития",
                            Number = 4
                        },
                        new
                        {
                            Id = 5,
                            Definition = "Ситуационное руководство",
                            Number = 5
                        },
                        new
                        {
                            Id = 6,
                            Definition = "Контроль и обратная связь",
                            Number = 6
                        },
                        new
                        {
                            Id = 7,
                            Definition = "Мотивация и вовлечение",
                            Number = 7
                        },
                        new
                        {
                            Id = 8,
                            Definition = "Подбор, адаптация и развитие",
                            Number = 8
                        },
                        new
                        {
                            Id = 9,
                            Definition = "Постановка задач и делегирование",
                            Number = 9
                        },
                        new
                        {
                            Id = 10,
                            Definition = "Секреты управления командой",
                            Number = 10
                        },
                        new
                        {
                            Id = 11,
                            Definition = "Цикл менеджмента",
                            Number = 11
                        },
                        new
                        {
                            Id = 12,
                            Definition = "Развитие управленческих навыков РОП",
                            Number = 12
                        },
                        new
                        {
                            Id = 13,
                            Definition = "Деловая переписка",
                            Number = 13
                        },
                        new
                        {
                            Id = 14,
                            Definition = "PowerPoint.Деловая презентация и визуализация",
                            Number = 14
                        },
                        new
                        {
                            Id = 15,
                            Definition = "Управление конфликтными ситуациями",
                            Number = 15
                        },
                        new
                        {
                            Id = 16,
                            Definition = "Работа с возражениями",
                            Number = 16
                        },
                        new
                        {
                            Id = 17,
                            Definition = "Эффективные коммуникации",
                            Number = 17
                        },
                        new
                        {
                            Id = 18,
                            Definition = "Повышение личной эффективности",
                            Number = 18
                        },
                        new
                        {
                            Id = 19,
                            Definition = "Лидерство",
                            Number = 19
                        },
                        new
                        {
                            Id = 20,
                            Definition = "Жизнестойкость",
                            Number = 20
                        },
                        new
                        {
                            Id = 21,
                            Definition = "Наставнический стиль",
                            Number = 21
                        },
                        new
                        {
                            Id = 22,
                            Definition = "Стратегии и тактики в переговарах",
                            Number = 22
                        },
                        new
                        {
                            Id = 23,
                            Definition = "Публичные выступления",
                            Number = 23
                        },
                        new
                        {
                            Id = 24,
                            Definition = "Системное мышление",
                            Number = 24
                        },
                        new
                        {
                            Id = 25,
                            Definition = "Тайм - менеджмент",
                            Number = 25
                        },
                        new
                        {
                            Id = 26,
                            Definition = "Эмоциональный интеллект",
                            Number = 26
                        },
                        new
                        {
                            Id = 27,
                            Definition = "DISC.Типология личности",
                            Number = 27
                        },
                        new
                        {
                            Id = 28,
                            Definition = "Креативное мышление",
                            Number = 28
                        },
                        new
                        {
                            Id = 29,
                            Definition = "Когнитивная гибкость",
                            Number = 29
                        },
                        new
                        {
                            Id = 30,
                            Definition = "Развитие памяти",
                            Number = 30
                        },
                        new
                        {
                            Id = 31,
                            Definition = "Критическое мышление",
                            Number = 31
                        },
                        new
                        {
                            Id = 32,
                            Definition = "Обратная связь",
                            Number = 32
                        },
                        new
                        {
                            Id = 33,
                            Definition = "Кросс - культурное взаимодействие",
                            Number = 33
                        },
                        new
                        {
                            Id = 34,
                            Definition = "Лидеры переговоров",
                            Number = 34
                        },
                        new
                        {
                            Id = 35,
                            Definition = "Скетчинг",
                            Number = 35
                        },
                        new
                        {
                            Id = 36,
                            Definition = "Развитие памяти",
                            Number = 36
                        },
                        new
                        {
                            Id = 37,
                            Definition = "Microsoft Excel(мобильное обучение)",
                            Number = 37
                        },
                        new
                        {
                            Id = 38,
                            Definition = "Принятие решений в условии неопределенности и риска",
                            Number = 38
                        },
                        new
                        {
                            Id = 39,
                            Definition = "Инструменты фасилитации",
                            Number = 39
                        },
                        new
                        {
                            Id = 40,
                            Definition = "Позитивное мышление",
                            Number = 40
                        },
                        new
                        {
                            Id = 41,
                            Definition = "Microsoft Excel(Тренинг Спейс)",
                            Number = 41
                        },
                        new
                        {
                            Id = 42,
                            Definition = "Верификация лжи",
                            Number = 42
                        },
                        new
                        {
                            Id = 43,
                            Definition = "Ассертивное поведение",
                            Number = 43
                        },
                        new
                        {
                            Id = 44,
                            Definition = "Манипулятивная коммуникация",
                            Number = 44
                        },
                        new
                        {
                            Id = 45,
                            Definition = "Манипуляции и ложь в переговорах",
                            Number = 45
                        },
                        new
                        {
                            Id = 46,
                            Definition = "Хочу быть наставником",
                            Number = 46
                        },
                        new
                        {
                            Id = 47,
                            Definition = "Эффективные переговоры с лицом, принимающим решения",
                            Number = 47
                        },
                        new
                        {
                            Id = 48,
                            Definition = "Холодные звонки",
                            Number = 48
                        },
                        new
                        {
                            Id = 49,
                            Definition = "Кросс - продажи",
                            Number = 49
                        },
                        new
                        {
                            Id = 50,
                            Definition = "Кросс - продукты",
                            Number = 50
                        },
                        new
                        {
                            Id = 51,
                            Definition = "Продажи.",
                            Number = 51
                        },
                        new
                        {
                            Id = 52,
                            Definition = "Школа персонального менеджмента",
                            Number = 52
                        },
                        new
                        {
                            Id = 53,
                            Definition = "Школа по обслуживанию клиента",
                            Number = 53
                        },
                        new
                        {
                            Id = 54,
                            Definition = "Повышение финансовой грамотности",
                            Number = 54
                        });
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.EnumsToEntities.EducationForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EducationForms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Очная",
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Заочная",
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            Definition = "Очно-заочная",
                            Number = 3
                        });
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.EnumsToEntities.EducationLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EducationLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "Колледж/Техникум",
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            Definition = "Бакалавриат",
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            Definition = "Специалитет",
                            Number = 3
                        },
                        new
                        {
                            Id = 4,
                            Definition = "Магистратура",
                            Number = 4
                        });
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.EnumsToEntities.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Specialities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "экономика",
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            Definition = "банковское дело",
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            Definition = "кредиты и финансы",
                            Number = 3
                        },
                        new
                        {
                            Id = 4,
                            Definition = "рынок ценных бумаг",
                            Number = 4
                        },
                        new
                        {
                            Id = 5,
                            Definition = "информационные технологии",
                            Number = 5
                        },
                        new
                        {
                            Id = 6,
                            Definition = "бизнес-информатика",
                            Number = 6
                        },
                        new
                        {
                            Id = 7,
                            Definition = "бизнес-аналитика",
                            Number = 7
                        },
                        new
                        {
                            Id = 8,
                            Definition = "финансовый менеджмент",
                            Number = 8
                        },
                        new
                        {
                            Id = 9,
                            Definition = "информационная безопасность",
                            Number = 9
                        },
                        new
                        {
                            Id = 10,
                            Definition = "математическое моделирование (прикладная математика)",
                            Number = 10
                        });
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.Grant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("AverageMarks")
                        .HasColumnType("real");

                    b.Property<string>("College")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Course")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EducationForm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

                    b.Property<string>("OtherGrants")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secondname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grant");
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.Practice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secondname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Practice");
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.PracticeFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PracticeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PracticeId");

                    b.ToTable("PracticeFile");
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.Probation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secondname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Probation");
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.ProbationFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProbationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProbationId");

                    b.ToTable("ProbationFile");
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("College")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCertificated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secondname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("University");
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.PracticeFile", b =>
                {
                    b.HasOne("ABB_BF.DAL.Entities.Practice", "Practice")
                        .WithMany("Files")
                        .HasForeignKey("PracticeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Practice");
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.ProbationFile", b =>
                {
                    b.HasOne("ABB_BF.DAL.Entities.Probation", "Probation")
                        .WithMany("Files")
                        .HasForeignKey("ProbationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Probation");
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.Practice", b =>
                {
                    b.Navigation("Files");
                });

            modelBuilder.Entity("ABB_BF.DAL.Entities.Probation", b =>
                {
                    b.Navigation("Files");
                });
#pragma warning restore 612, 618
        }
    }
}
