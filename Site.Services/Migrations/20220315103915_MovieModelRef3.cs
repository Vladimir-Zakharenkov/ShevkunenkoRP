using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class MovieModelRef3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImageModelImageId",
                table: "MovieModels",
                nullable: true,
                defaultValue: new Guid("A1C46E46-8E48-4998-0EF6-08D9F2AFBF48"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageModelImageId",
                table: "MovieModels");
        }
    }
}
