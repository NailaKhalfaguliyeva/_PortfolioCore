using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _PortfolioCore.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AbilityNumber",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbilityNumber",
                table: "Skills");
        }
    }
}
