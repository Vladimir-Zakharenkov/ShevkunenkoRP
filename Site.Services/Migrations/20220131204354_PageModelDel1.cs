using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class PageModelDel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageModels_HeadModels_HeadModelHeadId",
                table: "PageModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PageModels_ImageModels_ImageModelImageId",
                table: "PageModels");

            migrationBuilder.DropIndex(
                name: "IX_PageModels_HeadModelHeadId",
                table: "PageModels");

            migrationBuilder.DropIndex(
                name: "IX_PageModels_ImageModelImageId",
                table: "PageModels");

            migrationBuilder.DropColumn(
                name: "HeadModelHeadId",
                table: "PageModels");

            migrationBuilder.DropColumn(
                name: "ImageModelImageId",
                table: "PageModels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HeadModelHeadId",
                table: "PageModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ImageModelImageId",
                table: "PageModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PageModels_HeadModelHeadId",
                table: "PageModels",
                column: "HeadModelHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_PageModels_ImageModelImageId",
                table: "PageModels",
                column: "ImageModelImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PageModels_HeadModels_HeadModelHeadId",
                table: "PageModels",
                column: "HeadModelHeadId",
                principalTable: "HeadModels",
                principalColumn: "HeadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PageModels_ImageModels_ImageModelImageId",
                table: "PageModels",
                column: "ImageModelImageId",
                principalTable: "ImageModels",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
