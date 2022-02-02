using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class SitemapModelAddTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SitemapModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KeyWords",
                table: "SitemapModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "SitemapModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "SitemapModels");

            migrationBuilder.DropColumn(
                name: "KeyWords",
                table: "SitemapModels");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "SitemapModels");
        }
    }
}
