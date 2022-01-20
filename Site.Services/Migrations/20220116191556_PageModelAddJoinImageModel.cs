using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class PageModelAddJoinImageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImageModelImageId",
                table: "PageModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("7F919234-F469-4C90-2B71-08D9CFC07D7C"));

            migrationBuilder.CreateIndex(
                name: "IX_PageModels_ImageModelImageId",
                table: "PageModels",
                column: "ImageModelImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PageModels_ImageModels_ImageModelImageId",
                table: "PageModels",
                column: "ImageModelImageId",
                principalTable: "ImageModels",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageModels_ImageModels_ImageModelImageId",
                table: "PageModels");

            migrationBuilder.DropIndex(
                name: "IX_PageModels_ImageModelImageId",
                table: "PageModels");

            migrationBuilder.DropColumn(
                name: "ImageModelImageId",
                table: "PageModels");
        }
    }
}
