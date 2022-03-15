using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminAccess");

            migrationBuilder.DropTable(
                name: "CardModels");

            migrationBuilder.DropTable(
                name: "MovieModels");

            migrationBuilder.DropTable(
                name: "SitemapModels");

            migrationBuilder.DropTable(
                name: "ImageModels");
        }
    }
}
