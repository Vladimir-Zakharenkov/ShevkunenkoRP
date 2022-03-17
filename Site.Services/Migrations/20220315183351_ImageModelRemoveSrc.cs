using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class ImageModelRemoveSrc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName2",
                table: "ImageModels");

            migrationBuilder.DropColumn(
                name: "ImageSrc",
                table: "ImageModels");

            migrationBuilder.DropColumn(
                name: "ImageTitle",
                table: "ImageModels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName2",
                table: "ImageModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSrc",
                table: "ImageModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageTitle",
                table: "ImageModels",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
