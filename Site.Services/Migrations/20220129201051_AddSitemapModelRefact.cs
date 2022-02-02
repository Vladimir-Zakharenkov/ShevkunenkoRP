using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class AddSitemapModelRefact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Priority",
                table: "SitemapModels",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Priority",
                table: "SitemapModels",
                type: "float",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);
        }
    }
}
