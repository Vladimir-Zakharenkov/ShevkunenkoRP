using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class CardModelPlusMovieModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MovieModelMovieId",
                table: "CardModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("2EF09AE0-4337-4EBF-BAB7-E76189392873"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardModels_MovieModels_MovieModelMovieId",
                table: "CardModels");

            migrationBuilder.DropIndex(
                name: "IX_CardModels_MovieModelMovieId",
                table: "CardModels");

            migrationBuilder.DropColumn(
                name: "MovieModelMovieId",
                table: "CardModels");
        }
    }
}
