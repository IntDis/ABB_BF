using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABB_BF.DAL.Migrations
{
    public partial class fix_naming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GrantFiles_Grants_GrantId",
                table: "GrantFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_PracticeFiles_Practices_PracticeId",
                table: "PracticeFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_ProbationFiles_Probations_ProbationId",
                table: "ProbationFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Probations",
                table: "Probations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Practices",
                table: "Practices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grants",
                table: "Grants");

            migrationBuilder.RenameTable(
                name: "Probations",
                newName: "ProbationForms");

            migrationBuilder.RenameTable(
                name: "Practices",
                newName: "PracticeForms");

            migrationBuilder.RenameTable(
                name: "Grants",
                newName: "GrantForms");

            migrationBuilder.AddColumn<int>(
                name: "Direction",
                table: "UniversityForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Speciality",
                table: "GrantForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProbationForms",
                table: "ProbationForms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PracticeForms",
                table: "PracticeForms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GrantForms",
                table: "GrantForms",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantFiles_GrantForms_GrantId",
                table: "GrantFiles",
                column: "GrantId",
                principalTable: "GrantForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PracticeFiles_PracticeForms_PracticeId",
                table: "PracticeFiles",
                column: "PracticeId",
                principalTable: "PracticeForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProbationFiles_ProbationForms_ProbationId",
                table: "ProbationFiles",
                column: "ProbationId",
                principalTable: "ProbationForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GrantFiles_GrantForms_GrantId",
                table: "GrantFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_PracticeFiles_PracticeForms_PracticeId",
                table: "PracticeFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_ProbationFiles_ProbationForms_ProbationId",
                table: "ProbationFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProbationForms",
                table: "ProbationForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PracticeForms",
                table: "PracticeForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GrantForms",
                table: "GrantForms");

            migrationBuilder.DropColumn(
                name: "Direction",
                table: "UniversityForms");

            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "GrantForms");

            migrationBuilder.RenameTable(
                name: "ProbationForms",
                newName: "Probations");

            migrationBuilder.RenameTable(
                name: "PracticeForms",
                newName: "Practices");

            migrationBuilder.RenameTable(
                name: "GrantForms",
                newName: "Grants");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Probations",
                table: "Probations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Practices",
                table: "Practices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grants",
                table: "Grants",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantFiles_Grants_GrantId",
                table: "GrantFiles",
                column: "GrantId",
                principalTable: "Grants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PracticeFiles_Practices_PracticeId",
                table: "PracticeFiles",
                column: "PracticeId",
                principalTable: "Practices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProbationFiles_Probations_ProbationId",
                table: "ProbationFiles",
                column: "ProbationId",
                principalTable: "Probations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
