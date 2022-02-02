using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class DelPageHead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeadModels");

            migrationBuilder.DropTable(
                name: "PageModels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeadModels",
                columns: table => new
                {
                    HeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Canonical = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyWords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastReviewed = table.Column<DateTime>(type: "date", nullable: false),
                    PageNumber = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadModels", x => x.HeadId);
                });

            migrationBuilder.CreateTable(
                name: "PageModels",
                columns: table => new
                {
                    PageModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeftBackground = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<long>(type: "bigint", nullable: false),
                    RightBackground = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageModels", x => x.PageModelId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PageModels_PageNumber",
                table: "PageModels",
                column: "PageNumber",
                unique: true);
        }
    }
}
