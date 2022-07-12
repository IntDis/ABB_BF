using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABB_BF.DAL.Migrations
{
    public partial class added_sv_file_in_probation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Cv",
                table: "Probations",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cv",
                table: "Probations");
        }
    }
}
