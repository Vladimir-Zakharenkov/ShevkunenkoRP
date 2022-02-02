using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class AddSitemapModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SitemapModels",
                columns: table => new
                {
                    SitemapModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageNumber = table.Column<long>(type: "bigint", nullable: false),
                    Loc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastmod = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Changefreq = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    Priority = table.Column<double>(type: "float", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SitemapModels", x => x.SitemapModelId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PageModels_PageNumber",
                table: "PageModels",
                column: "PageNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SitemapModels_PageNumber",
                table: "SitemapModels",
                column: "PageNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SitemapModels");

            migrationBuilder.DropIndex(
                name: "IX_PageModels_PageNumber",
                table: "PageModels");
        }
    }
}
