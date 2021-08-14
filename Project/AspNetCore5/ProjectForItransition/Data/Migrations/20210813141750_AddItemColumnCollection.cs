using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Data.Migrations
{
    public partial class AddItemColumnCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Collections_ContentCollectionId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "ContentCollectionId",
                table: "Items",
                newName: "CollectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ContentCollectionId",
                table: "Items",
                newName: "IX_Items_CollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Collections_CollectionId",
                table: "Items",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Collections_CollectionId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "CollectionId",
                table: "Items",
                newName: "ContentCollectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_CollectionId",
                table: "Items",
                newName: "IX_Items_ContentCollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Collections_ContentCollectionId",
                table: "Items",
                column: "ContentCollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
