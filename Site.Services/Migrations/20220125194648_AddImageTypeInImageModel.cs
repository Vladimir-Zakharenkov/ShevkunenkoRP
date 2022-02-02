using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class AddImageTypeInImageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageType",
                table: "ImageModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageType",
                table: "ImageModels");
        }
    }
}
