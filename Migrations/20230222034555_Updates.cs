using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB315_Assignments_ThemeCricket.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ThemeCricket",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "ThemeCricket",
                newName: "BookingDate");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "ThemeCricket",
                newName: "StadiumName");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "ThemeCricket",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "ThemeCricket");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "ThemeCricket",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "StadiumName",
                table: "ThemeCricket",
                newName: "Genre");

            migrationBuilder.RenameColumn(
                name: "BookingDate",
                table: "ThemeCricket",
                newName: "ReleaseDate");
        }
    }
}
