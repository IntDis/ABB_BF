using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABB_BF.DAL.Migrations
{
    public partial class added_is_checked_prop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "UniversityForms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "ProbationForms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "PracticeForms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "GrantForms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "UniversityForms");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "ProbationForms");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "PracticeForms");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "GrantForms");
        }
    }
}
