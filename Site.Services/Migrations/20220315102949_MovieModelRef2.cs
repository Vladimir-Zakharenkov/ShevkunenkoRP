using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class MovieModelRef2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieModels_ImageModels_ImageModelImageId",
                table: "MovieModels");

            migrationBuilder.DropIndex(
                name: "IX_MovieModels_ImageModelImageId",
                table: "MovieModels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MovieModels_ImageModelImageId",
                table: "MovieModels",
                column: "ImageModelImageId");

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
