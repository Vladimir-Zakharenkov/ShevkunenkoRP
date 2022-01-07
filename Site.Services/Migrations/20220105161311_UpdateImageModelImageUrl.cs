using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class UpdateImageModelImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagelUrl",
                table: "ImageModels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagelUrl",
                table: "ImageModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
