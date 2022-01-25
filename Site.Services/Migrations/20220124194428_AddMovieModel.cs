using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class AddMovieModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieModels",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieCaption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePublished = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFamilyFriendly = table.Column<bool>(type: "bit", nullable: false),
                    InLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    РroductionCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusicBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actor01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actor02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actor03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actor04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actor05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actor06 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actor07 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actor08 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actor09 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actor10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageModelImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieModels", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_MovieModels_ImageModels_ImageModelImageId",
                        column: x => x.ImageModelImageId,
                        principalTable: "ImageModels",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieModels_ImageModelImageId",
                table: "MovieModels",
                column: "ImageModelImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieModels");
        }
    }
}
