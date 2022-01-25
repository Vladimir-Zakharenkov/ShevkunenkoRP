using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class HeadModelToPageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HeadModelHeadId",
                table: "PageModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("D5B72D47-9068-469F-92B6-A24BFB1CADA1"));

            migrationBuilder.CreateIndex(
                name: "IX_PageModels_HeadModelHeadId",
                table: "PageModels",
                column: "HeadModelHeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_PageModels_HeadModels_HeadModelHeadId",
                table: "PageModels",
                column: "HeadModelHeadId",
                principalTable: "HeadModels",
                principalColumn: "HeadId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageModels_HeadModels_HeadModelHeadId",
                table: "PageModels");

            migrationBuilder.DropIndex(
                name: "IX_PageModels_HeadModelHeadId",
                table: "PageModels");

            migrationBuilder.DropColumn(
                name: "HeadModelHeadId",
                table: "PageModels");
        }
    }
}
