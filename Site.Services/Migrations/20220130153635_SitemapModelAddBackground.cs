using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class SitemapModelAddBackground : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LeftBackground",
                table: "SitemapModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RightBackground",
                table: "SitemapModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeftBackground",
                table: "SitemapModels");

            migrationBuilder.DropColumn(
                name: "RightBackground",
                table: "SitemapModels");
        }
    }
}
