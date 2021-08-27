using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Repository.Migrations
{
    public partial class ChangeOptionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OptionElements_Items_ItemId",
                table: "OptionElements");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "OptionElements",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OptionElements_ItemId",
                table: "OptionElements",
                newName: "IX_OptionElements_ContentItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OptionElements_Items_ContentItemId",
                table: "OptionElements",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OptionElements_Items_ContentItemId",
                table: "OptionElements");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "OptionElements",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OptionElements_ContentItemId",
                table: "OptionElements",
                newName: "IX_OptionElements_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OptionElements_Items_ItemId",
                table: "OptionElements",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
