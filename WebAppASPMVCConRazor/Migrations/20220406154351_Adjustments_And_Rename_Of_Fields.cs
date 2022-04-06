using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppASPMVCConRazor.Migrations
{
    public partial class Adjustments_And_Rename_Of_Fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dateTime",
                table: "Movie",
                newName: "ReleaseDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Movie",
                newName: "dateTime");
        }
    }
}
