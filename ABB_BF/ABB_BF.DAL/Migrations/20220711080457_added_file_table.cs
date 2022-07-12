using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABB_BF.DAL.Migrations
{
    public partial class added_file_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Probations");

            migrationBuilder.DropColumn(
                name: "Cv",
                table: "Probations");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Probations");

            migrationBuilder.DropColumn(
                name: "AverageMarks",
                table: "Practices");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Grants");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Grants");

            migrationBuilder.DropColumn(
                name: "EducationForm",
                table: "Grants");

            migrationBuilder.RenameColumn(
                name: "Speciality",
                table: "Grants",
                newName: "City");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "UniversityForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UniversityForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsCertificated",
                table: "UniversityForms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Probations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Practices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Practices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_Probations_FormId",
                        column: x => x.FormId,
                        principalTable: "Probations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Files_FormId",
                table: "Files",
                column: "FormId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropColumn(
                name: "City",
                table: "UniversityForms");

            migrationBuilder.DropColumn(
                name: "IsCertificated",
                table: "UniversityForms");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Probations");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Practices");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Grants",
                newName: "Speciality");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "UniversityForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Probations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Cv",
                table: "Probations",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Probations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Practices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<float>(
                name: "AverageMarks",
                table: "Practices",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Grants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Grants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EducationForm",
                table: "Grants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
