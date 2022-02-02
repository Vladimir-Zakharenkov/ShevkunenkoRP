using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class SitemapModelAddImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImageModelImageId",
                table: "SitemapModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("7F919234-F469-4C90-2B71-08D9CFC07D7C"));

            migrationBuilder.CreateIndex(
                name: "IX_SitemapModels_ImageModelImageId",
                table: "SitemapModels",
                column: "ImageModelImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_SitemapModels_ImageModels_ImageModelImageId",
                table: "SitemapModels",
                column: "ImageModelImageId",
                principalTable: "ImageModels",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SitemapModels_ImageModels_ImageModelImageId",
                table: "SitemapModels");

            migrationBuilder.DropIndex(
                name: "IX_SitemapModels_ImageModelImageId",
                table: "SitemapModels");

            migrationBuilder.DropColumn(
                name: "ImageModelImageId",
                table: "SitemapModels");
        }
    }
}
