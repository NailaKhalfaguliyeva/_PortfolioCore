using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _PortfolioCore.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Testimonials",
                newName: "CommentDetail");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "Experiences",
                newName: "SubTitle");

            migrationBuilder.RenameColumn(
                name: "University",
                table: "Educations",
                newName: "SubTitle");

            migrationBuilder.RenameColumn(
                name: "EducationDate",
                table: "Educations",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Educations",
                newName: "DateInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentDetail",
                table: "Testimonials",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "SubTitle",
                table: "Experiences",
                newName: "Subtitle");

            migrationBuilder.RenameColumn(
                name: "SubTitle",
                table: "Educations",
                newName: "University");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Educations",
                newName: "EducationDate");

            migrationBuilder.RenameColumn(
                name: "DateInfo",
                table: "Educations",
                newName: "Department");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                });
        }
    }
}
