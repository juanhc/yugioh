using Microsoft.EntityFrameworkCore.Migrations;

namespace YuGiOh.Infraestructure.Migrations
{
    public partial class AddDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardImage_Cards_CardId",
                table: "CardImage");

            migrationBuilder.DropForeignKey(
                name: "FK_CardPrice_Cards_CardId",
                table: "CardPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_CardSet_Cards_CardId",
                table: "CardSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardSet",
                table: "CardSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardPrice",
                table: "CardPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardImage",
                table: "CardImage");

            migrationBuilder.RenameTable(
                name: "CardSet",
                newName: "CardSets");

            migrationBuilder.RenameTable(
                name: "CardPrice",
                newName: "CardPrices");

            migrationBuilder.RenameTable(
                name: "CardImage",
                newName: "CardImages");

            migrationBuilder.RenameIndex(
                name: "IX_CardSet_CardId",
                table: "CardSets",
                newName: "IX_CardSets_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_CardPrice_CardId",
                table: "CardPrices",
                newName: "IX_CardPrices_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_CardImage_CardId",
                table: "CardImages",
                newName: "IX_CardImages_CardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardSets",
                table: "CardSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardPrices",
                table: "CardPrices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardImages",
                table: "CardImages",
                column: "Id");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardSets",
                table: "CardSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardPrices",
                table: "CardPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardImages",
                table: "CardImages");

            migrationBuilder.RenameTable(
                name: "CardSets",
                newName: "CardSet");

            migrationBuilder.RenameTable(
                name: "CardPrices",
                newName: "CardPrice");

            migrationBuilder.RenameTable(
                name: "CardImages",
                newName: "CardImage");

            migrationBuilder.RenameIndex(
                name: "IX_CardSets_CardId",
                table: "CardSet",
                newName: "IX_CardSet_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_CardPrices_CardId",
                table: "CardPrice",
                newName: "IX_CardPrice_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_CardImages_CardId",
                table: "CardImage",
                newName: "IX_CardImage_CardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardSet",
                table: "CardSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardPrice",
                table: "CardPrice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardImage",
                table: "CardImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CardImage_Cards_CardId",
                table: "CardImage",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CardPrice_Cards_CardId",
                table: "CardPrice",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CardSet_Cards_CardId",
                table: "CardSet",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
