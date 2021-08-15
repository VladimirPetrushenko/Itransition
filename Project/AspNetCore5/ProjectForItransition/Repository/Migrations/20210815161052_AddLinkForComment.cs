using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Repository.Migrations
{
    public partial class AddLinkForComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Items_ContentItemId",
                table: "Comment");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "Comment",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_ContentItemId",
                table: "Comment",
                newName: "IX_Comment_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Items_ItemId",
                table: "Comment",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Items_ItemId",
                table: "Comment");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Comment",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_ItemId",
                table: "Comment",
                newName: "IX_Comment_ContentItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Items_ContentItemId",
                table: "Comment",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
