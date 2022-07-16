using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABB_BF.DAL.Migrations
{
    public partial class added_college_table_and_rename_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PracticeFiles_PracticeForms_PracticeId",
                table: "PracticeFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_ProbationFiles_ProbationForms_ProbationId",
                table: "ProbationFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UniversityForms",
                table: "UniversityForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProbationForms",
                table: "ProbationForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProbationFiles",
                table: "ProbationFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PracticeForms",
                table: "PracticeForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PracticeFiles",
                table: "PracticeFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GrantForms",
                table: "GrantForms");

            migrationBuilder.RenameTable(
                name: "UniversityForms",
                newName: "University");

            migrationBuilder.RenameTable(
                name: "ProbationForms",
                newName: "Probation");

            migrationBuilder.RenameTable(
                name: "ProbationFiles",
                newName: "ProbationFile");

            migrationBuilder.RenameTable(
                name: "PracticeForms",
                newName: "Practice");

            migrationBuilder.RenameTable(
                name: "PracticeFiles",
                newName: "PracticeFile");

            migrationBuilder.RenameTable(
                name: "GrantForms",
                newName: "Grant");

            migrationBuilder.RenameIndex(
                name: "IX_ProbationFiles_ProbationId",
                table: "ProbationFile",
                newName: "IX_ProbationFile_ProbationId");

            migrationBuilder.RenameIndex(
                name: "IX_PracticeFiles_PracticeId",
                table: "PracticeFile",
                newName: "IX_PracticeFile_PracticeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_University",
                table: "University",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Probation",
                table: "Probation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProbationFile",
                table: "ProbationFile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Practice",
                table: "Practice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PracticeFile",
                table: "PracticeFile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grant",
                table: "Grant",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PracticeFile_Practice_PracticeId",
                table: "PracticeFile",
                column: "PracticeId",
                principalTable: "Practice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProbationFile_Probation_ProbationId",
                table: "ProbationFile",
                column: "ProbationId",
                principalTable: "Probation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PracticeFile_Practice_PracticeId",
                table: "PracticeFile");

            migrationBuilder.DropForeignKey(
                name: "FK_ProbationFile_Probation_ProbationId",
                table: "ProbationFile");

            migrationBuilder.DropTable(
                name: "College");

            migrationBuilder.DropPrimaryKey(
                name: "PK_University",
                table: "University");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProbationFile",
                table: "ProbationFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Probation",
                table: "Probation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PracticeFile",
                table: "PracticeFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Practice",
                table: "Practice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grant",
                table: "Grant");

            migrationBuilder.RenameTable(
                name: "University",
                newName: "UniversityForms");

            migrationBuilder.RenameTable(
                name: "ProbationFile",
                newName: "ProbationFiles");

            migrationBuilder.RenameTable(
                name: "Probation",
                newName: "ProbationForms");

            migrationBuilder.RenameTable(
                name: "PracticeFile",
                newName: "PracticeFiles");

            migrationBuilder.RenameTable(
                name: "Practice",
                newName: "PracticeForms");

            migrationBuilder.RenameTable(
                name: "Grant",
                newName: "GrantForms");

            migrationBuilder.RenameIndex(
                name: "IX_ProbationFile_ProbationId",
                table: "ProbationFiles",
                newName: "IX_ProbationFiles_ProbationId");

            migrationBuilder.RenameIndex(
                name: "IX_PracticeFile_PracticeId",
                table: "PracticeFiles",
                newName: "IX_PracticeFiles_PracticeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UniversityForms",
                table: "UniversityForms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProbationFiles",
                table: "ProbationFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProbationForms",
                table: "ProbationForms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PracticeFiles",
                table: "PracticeFiles",
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
    }
}
