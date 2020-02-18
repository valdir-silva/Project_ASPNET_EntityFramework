using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWeb.Migrations
{
    public partial class concertarCagada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRetord_Seller_SellerId",
                table: "SalesRetord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRetord",
                table: "SalesRetord");

            migrationBuilder.RenameTable(
                name: "SalesRetord",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRetord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SalesRetord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRetord",
                newName: "IX_SalesRetord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRetord",
                table: "SalesRetord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRetord_Seller_SellerId",
                table: "SalesRetord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
