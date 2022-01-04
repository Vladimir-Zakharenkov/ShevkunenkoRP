using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class AddImageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageModels",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageCaption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageContentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagelUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageWidth = table.Column<int>(type: "int", nullable: false),
                    ImageHeight = table.Column<int>(type: "int", nullable: false),
                    ImageSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageModels", x => x.ImageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageModels");
        }
    }
}
