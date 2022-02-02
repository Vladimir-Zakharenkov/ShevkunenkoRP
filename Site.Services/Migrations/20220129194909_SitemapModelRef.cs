using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class SitemapModelRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Changefreq",
                table: "SitemapModels",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 7);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Changefreq",
                table: "SitemapModels",
                type: "int",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);
        }
    }
}
