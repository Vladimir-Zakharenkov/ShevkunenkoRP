using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Services.Migrations
{
    public partial class AddCardModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardModels",
                columns: table => new
                {
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardBody = table.Column<bool>(type: "bit", nullable: false),
                    CardText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardModels", x => x.CardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardModels");
        }
    }
}
