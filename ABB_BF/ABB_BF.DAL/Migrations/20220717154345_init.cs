using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABB_BF.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "College",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_College", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseDirections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDirections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course = table.Column<int>(type: "int", nullable: false),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationForm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageMarks = table.Column<float>(type: "real", nullable: false),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherGrants = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secondname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Practice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secondname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Probation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secondname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Probation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCertificated = table.Column<bool>(type: "bit", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secondname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PracticeFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PracticeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticeFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticeFile_Practice_PracticeId",
                        column: x => x.PracticeId,
                        principalTable: "Practice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProbationFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProbationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProbationFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProbationFile_Probation_ProbationId",
                        column: x => x.ProbationId,
                        principalTable: "Probation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CourseDirections",
                columns: new[] { "Id", "Definition", "Number" },
                values: new object[,]
                {
                    { 1, "Welcome тренинг", 1 },
                    { 2, "Активные продажи по телефону ЮЛ", 2 },
                    { 3, "Развитие управленческих навыков РОП", 3 },
                    { 4, "Индивидуальный план развития", 4 },
                    { 5, "Ситуационное руководство", 5 },
                    { 6, "Контроль и обратная связь", 6 },
                    { 7, "Мотивация и вовлечение", 7 },
                    { 8, "Подбор, адаптация и развитие", 8 },
                    { 9, "Постановка задач и делегирование", 9 },
                    { 10, "Секреты управления командой", 10 },
                    { 11, "Цикл менеджмента", 11 },
                    { 12, "Развитие управленческих навыков РОП", 12 },
                    { 13, "Деловая переписка", 13 },
                    { 14, "PowerPoint.Деловая презентация и визуализация", 14 },
                    { 15, "Управление конфликтными ситуациями", 15 },
                    { 16, "Работа с возражениями", 16 },
                    { 17, "Эффективные коммуникации", 17 },
                    { 18, "Повышение личной эффективности", 18 },
                    { 19, "Лидерство", 19 },
                    { 20, "Жизнестойкость", 20 },
                    { 21, "Наставнический стиль", 21 },
                    { 22, "Стратегии и тактики в переговарах", 22 },
                    { 23, "Публичные выступления", 23 },
                    { 24, "Системное мышление", 24 },
                    { 25, "Тайм - менеджмент", 25 },
                    { 26, "Эмоциональный интеллект", 26 },
                    { 27, "DISC.Типология личности", 27 },
                    { 28, "Креативное мышление", 28 },
                    { 29, "Когнитивная гибкость", 29 },
                    { 30, "Развитие памяти", 30 },
                    { 31, "Критическое мышление", 31 },
                    { 32, "Обратная связь", 32 },
                    { 33, "Кросс - культурное взаимодействие", 33 },
                    { 34, "Лидеры переговоров", 34 },
                    { 35, "Скетчинг", 35 },
                    { 36, "Развитие памяти", 36 },
                    { 37, "Microsoft Excel(мобильное обучение)", 37 },
                    { 38, "Принятие решений в условии неопределенности и риска", 38 },
                    { 39, "Инструменты фасилитации", 39 },
                    { 40, "Позитивное мышление", 40 },
                    { 41, "Microsoft Excel(Тренинг Спейс)", 41 },
                    { 42, "Верификация лжи", 42 }
                });

            migrationBuilder.InsertData(
                table: "CourseDirections",
                columns: new[] { "Id", "Definition", "Number" },
                values: new object[,]
                {
                    { 43, "Ассертивное поведение", 43 },
                    { 44, "Манипулятивная коммуникация", 44 },
                    { 45, "Манипуляции и ложь в переговорах", 45 },
                    { 46, "Хочу быть наставником", 46 },
                    { 47, "Эффективные переговоры с лицом, принимающим решения", 47 },
                    { 48, "Холодные звонки", 48 },
                    { 49, "Кросс - продажи", 49 },
                    { 50, "Кросс - продукты", 50 },
                    { 51, "Продажи.", 51 },
                    { 52, "Школа персонального менеджмента", 52 },
                    { 53, "Школа по обслуживанию клиента", 53 },
                    { 54, "Повышение финансовой грамотности", 54 }
                });

            migrationBuilder.InsertData(
                table: "EducationForms",
                columns: new[] { "Id", "Definition", "Number" },
                values: new object[,]
                {
                    { 1, "Очная", 1 },
                    { 2, "Заочная", 2 },
                    { 3, "Очно-заочная", 3 }
                });

            migrationBuilder.InsertData(
                table: "EducationLevels",
                columns: new[] { "Id", "Definition", "Number" },
                values: new object[,]
                {
                    { 1, "Колледж/Техникум", 1 },
                    { 2, "Бакалавриат", 2 },
                    { 3, "Специалитет", 3 },
                    { 4, "Магистратура", 4 }
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Definition", "Number" },
                values: new object[,]
                {
                    { 1, "экономика", 1 },
                    { 2, "банковское дело", 2 },
                    { 3, "кредиты и финансы", 3 },
                    { 4, "рынок ценных бумаг", 4 },
                    { 5, "информационные технологии", 5 },
                    { 6, "бизнес-информатика", 6 },
                    { 7, "бизнес-аналитика", 7 },
                    { 8, "финансовый менеджмент", 8 },
                    { 9, "информационная безопасность", 9 },
                    { 10, "математическое моделирование (прикладная математика)", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PracticeFile_PracticeId",
                table: "PracticeFile",
                column: "PracticeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProbationFile_ProbationId",
                table: "ProbationFile",
                column: "ProbationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "College");

            migrationBuilder.DropTable(
                name: "CourseDirections");

            migrationBuilder.DropTable(
                name: "EducationForms");

            migrationBuilder.DropTable(
                name: "EducationLevels");

            migrationBuilder.DropTable(
                name: "Grant");

            migrationBuilder.DropTable(
                name: "PracticeFile");

            migrationBuilder.DropTable(
                name: "ProbationFile");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropTable(
                name: "University");

            migrationBuilder.DropTable(
                name: "Practice");

            migrationBuilder.DropTable(
                name: "Probation");
        }
    }
}
