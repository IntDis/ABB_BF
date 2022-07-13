using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABB_BF.DAL.Migrations
{
    public partial class fix_after_change_requires : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrantFiles");

            migrationBuilder.DropTable(
                name: "UniversityFiles");

            migrationBuilder.DropColumn(
                name: "City",
                table: "UniversityForms");

            migrationBuilder.DropColumn(
                name: "City",
                table: "ProbationForms");

            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "PracticeForms");

            migrationBuilder.DropColumn(
                name: "City",
                table: "PracticeForms");

            migrationBuilder.DropColumn(
                name: "College",
                table: "PracticeForms");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "PracticeForms");

            migrationBuilder.DropColumn(
                name: "Course",
                table: "PracticeForms");

            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "PracticeForms");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "PracticeForms");

            migrationBuilder.DropColumn(
                name: "City",
                table: "GrantForms");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "UniversityForms",
                newName: "College");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "UniversityForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "UniversityForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "UniversityForms");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "UniversityForms");

            migrationBuilder.RenameColumn(
                name: "College",
                table: "UniversityForms",
                newName: "Comment");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UniversityForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "ProbationForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "PracticeForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "PracticeForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "College",
                table: "PracticeForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "PracticeForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Course",
                table: "PracticeForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "PracticeForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "PracticeForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "GrantForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "GrantFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrantId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrantFiles_GrantForms_GrantId",
                        column: x => x.GrantId,
                        principalTable: "GrantForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniversityFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UniversityFiles_UniversityForms_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "UniversityForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrantFiles_GrantId",
                table: "GrantFiles",
                column: "GrantId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityFiles_UniversityId",
                table: "UniversityFiles",
                column: "UniversityId");
        }
    }
}
