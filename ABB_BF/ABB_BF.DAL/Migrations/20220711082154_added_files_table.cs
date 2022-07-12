using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABB_BF.DAL.Migrations
{
    public partial class added_files_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrantFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrantId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrantFiles_Grants_GrantId",
                        column: x => x.GrantId,
                        principalTable: "Grants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PracticeFiles",
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
                    table.PrimaryKey("PK_PracticeFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticeFiles_Practices_PracticeId",
                        column: x => x.PracticeId,
                        principalTable: "Practices",
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
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
                name: "IX_PracticeFiles_PracticeId",
                table: "PracticeFiles",
                column: "PracticeId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityFiles_UniversityId",
                table: "UniversityFiles",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrantFiles");

            migrationBuilder.DropTable(
                name: "PracticeFiles");

            migrationBuilder.DropTable(
                name: "UniversityFiles");
        }
    }
}
