using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manage_core.Migrations
{
    public partial class emplo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "WorkNumber",
                table: "Personal",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    WorkNumber = table.Column<string>(nullable: false),
                    IdCard = table.Column<string>(nullable: true),
                    WorkState = table.Column<string>(nullable: true),
                    ClassOfSalary = table.Column<int>(nullable: false),
                    ClassOfEmployee = table.Column<int>(nullable: false),
                    DateOfJoin = table.Column<DateTime>(nullable: true),
                    LeaveDate = table.Column<DateTime>(nullable: true),
                    ReasonOfLeaveing = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.WorkNumber);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personal_WorkNumber",
                table: "Personal",
                column: "WorkNumber",
                unique: true,
                filter: "[WorkNumber] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Employee_WorkNumber",
                table: "Personal",
                column: "WorkNumber",
                principalTable: "Employee",
                principalColumn: "WorkNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personal_Employee_WorkNumber",
                table: "Personal");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Personal_WorkNumber",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "WorkNumber",
                table: "Personal");

            migrationBuilder.AddColumn<string>(
                name: "WorkId",
                table: "Personal",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personal_WorkId",
                table: "Personal",
                column: "WorkId",
                unique: true,
                filter: "[WorkId] IS NOT NULL");
        }
    }
}
