using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB315_Assignments_ThemeCricket.Migrations
{
    public partial class rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "ThemeCricket",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstMatch",
                table: "ThemeCricket",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "ThemeCricket");

            migrationBuilder.DropColumn(
                name: "FirstMatch",
                table: "ThemeCricket");
        }
    }
}
