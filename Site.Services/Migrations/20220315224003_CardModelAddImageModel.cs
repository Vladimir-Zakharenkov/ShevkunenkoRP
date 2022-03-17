using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class CardModelAddImageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImageModelImageId",
                table: "CardModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("9DFC87B8-B8CD-47F8-A147-9ED335227221"));

            migrationBuilder.CreateIndex(
                name: "IX_CardModels_ImageModelImageId",
                table: "CardModels",
                column: "ImageModelImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardModels_ImageModels_ImageModelImageId",
                table: "CardModels",
                column: "ImageModelImageId",
                principalTable: "ImageModels",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardModels_ImageModels_ImageModelImageId",
                table: "CardModels");

            migrationBuilder.DropIndex(
                name: "IX_CardModels_ImageModelImageId",
                table: "CardModels");

            migrationBuilder.DropColumn(
                name: "ImageModelImageId",
                table: "CardModels");
        }
    }
}
