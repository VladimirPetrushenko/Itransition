using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Repository.Migrations
{
    public partial class changeLikeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Items_ContentItemId",
                table: "Likes");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "Likes",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_ContentItemId",
                table: "Likes",
                newName: "IX_Likes_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Items_ItemId",
                table: "Likes",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Items_ItemId",
                table: "Likes");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Likes",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_ItemId",
                table: "Likes",
                newName: "IX_Likes_ContentItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Items_ContentItemId",
                table: "Likes",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
