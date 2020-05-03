using Microsoft.EntityFrameworkCore.Migrations;

namespace YuGiOh.Infraestructure.Migrations
{
    public partial class CardId_NotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardImages_Cards_CardId",
                table: "CardImages");

            migrationBuilder.DropForeignKey(
                name: "FK_CardPrices_Cards_CardId",
                table: "CardPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_CardSets_Cards_CardId",
                table: "CardSets");

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "CardSets",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "CardPrices",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "CardImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CardImages_Cards_CardId",
                table: "CardImages",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardPrices_Cards_CardId",
                table: "CardPrices",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardSets_Cards_CardId",
                table: "CardSets",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardImages_Cards_CardId",
                table: "CardImages");

            migrationBuilder.DropForeignKey(
                name: "FK_CardPrices_Cards_CardId",
                table: "CardPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_CardSets_Cards_CardId",
                table: "CardSets");

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "CardSets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "CardPrices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "CardImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CardImages_Cards_CardId",
                table: "CardImages",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CardPrices_Cards_CardId",
                table: "CardPrices",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CardSets_Cards_CardId",
                table: "CardSets",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
