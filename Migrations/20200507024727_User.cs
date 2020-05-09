using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manage_core.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "User",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    IdentityCard = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Marriage = table.Column<int>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Nation = table.Column<string>(nullable: true),
                    HouseHold = table.Column<string>(nullable: true),
                    Rear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.IdentityCard);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropColumn(
                name: "email",
                table: "User");
        }
    }
}
