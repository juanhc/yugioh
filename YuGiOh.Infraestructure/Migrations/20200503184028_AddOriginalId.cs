using Microsoft.EntityFrameworkCore.Migrations;

namespace YuGiOh.Infraestructure.Migrations
{
    public partial class AddOriginalId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OriginalId",
                table: "Cards",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalId",
                table: "Cards");
        }
    }
}
