using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class MovieModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieModels_ImageModels_ImageModelImageId",
                table: "MovieModels");

            migrationBuilder.DropIndex(
                name: "IX_MovieModels_ImageModelImageId",
                table: "MovieModels");

            migrationBuilder.DropColumn(
                name: "ImageModelImageId",
                table: "MovieModels");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImageModelImageId",
                table: "MovieModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MovieModelMovieId",
                table: "CardModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_MovieModels_ImageModelImageId",
                table: "MovieModels",
                column: "ImageModelImageId");

            migrationBuilder.CreateIndex(
                name: "IX_CardModels_MovieModelMovieId",
                table: "CardModels",
                column: "MovieModelMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardModels_MovieModels_MovieModelMovieId",
                table: "CardModels",
                column: "MovieModelMovieId",
                principalTable: "MovieModels",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieModels_ImageModels_ImageModelImageId",
                table: "MovieModels",
                column: "ImageModelImageId",
                principalTable: "ImageModels",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
