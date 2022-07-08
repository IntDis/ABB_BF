using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABB_BF.DAL.Migrations
{
    public partial class added_Files_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grants");

            migrationBuilder.DropTable(
                name: "Practices");

            migrationBuilder.DropTable(
                name: "Probations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UniversityForms",
                table: "UniversityForms");

            migrationBuilder.RenameTable(
                name: "UniversityForms",
                newName: "AbstractCommonData");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "AbstractCommonData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "AverageMarks",
                table: "AbstractCommonData",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AbstractCommonData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "College",
                table: "AbstractCommonData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Course",
                table: "AbstractCommonData",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AbstractCommonData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EducationForm",
                table: "AbstractCommonData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EducationLevel",
                table: "AbstractCommonData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherGrants",
                table: "AbstractCommonData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Practice_AverageMarks",
                table: "AbstractCommonData",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Practice_College",
                table: "AbstractCommonData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Practice_Course",
                table: "AbstractCommonData",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Practice_Speciality",
                table: "AbstractCommonData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Probation_StartDate",
                table: "AbstractCommonData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "AbstractCommonData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "AbstractCommonData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbstractCommonData",
                table: "AbstractCommonData",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    ProbationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_AbstractCommonData_FormId",
                        column: x => x.FormId,
                        principalTable: "AbstractCommonData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Files_AbstractCommonData_ProbationId",
                        column: x => x.ProbationId,
                        principalTable: "AbstractCommonData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Files_FormId",
                table: "Files",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ProbationId",
                table: "Files",
                column: "ProbationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbstractCommonData",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "AverageMarks",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "College",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "Course",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "EducationForm",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "EducationLevel",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "OtherGrants",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "Practice_AverageMarks",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "Practice_College",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "Practice_Course",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "Practice_Speciality",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "Probation_StartDate",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "AbstractCommonData");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "AbstractCommonData");

            migrationBuilder.RenameTable(
                name: "AbstractCommonData",
                newName: "UniversityForms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UniversityForms",
                table: "UniversityForms",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Grants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AverageMarks = table.Column<float>(type: "real", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course = table.Column<int>(type: "int", nullable: false),
                    EducationForm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherGrants = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secondname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Practices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageMarks = table.Column<float>(type: "real", nullable: false),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secondname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Probations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cv = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secondname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Probations", x => x.Id);
                });
        }
    }
}
