using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Repository.Migrations
{
    public partial class NewMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckboxElements_Items_ItemId",
                table: "CheckboxElements");

            migrationBuilder.DropForeignKey(
                name: "FK_DateTimeOffsetElements_Items_ItemId",
                table: "DateTimeOffsetElements");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegerElements_Items_ItemId",
                table: "IntegerElements");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Collections_CollectionId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkdownElements_Items_ItemId",
                table: "MarkdownElements");

            migrationBuilder.DropForeignKey(
                name: "FK_NameFields_Collections_CollectionId",
                table: "NameFields");

            migrationBuilder.DropForeignKey(
                name: "FK_StringElements_Items_ItemId",
                table: "StringElements");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "StringElements",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_StringElements_ItemId",
                table: "StringElements",
                newName: "IX_StringElements_ContentItemId");

            migrationBuilder.RenameColumn(
                name: "CollectionId",
                table: "NameFields",
                newName: "ContentCollectionId");

            migrationBuilder.RenameIndex(
                name: "IX_NameFields_CollectionId",
                table: "NameFields",
                newName: "IX_NameFields_ContentCollectionId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "MarkdownElements",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_MarkdownElements_ItemId",
                table: "MarkdownElements",
                newName: "IX_MarkdownElements_ContentItemId");

            migrationBuilder.RenameColumn(
                name: "CollectionId",
                table: "Items",
                newName: "ContentCollectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_CollectionId",
                table: "Items",
                newName: "IX_Items_ContentCollectionId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "IntegerElements",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_IntegerElements_ItemId",
                table: "IntegerElements",
                newName: "IX_IntegerElements_ContentItemId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "DateTimeOffsetElements",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_DateTimeOffsetElements_ItemId",
                table: "DateTimeOffsetElements",
                newName: "IX_DateTimeOffsetElements_ContentItemId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "CheckboxElements",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckboxElements_ItemId",
                table: "CheckboxElements",
                newName: "IX_CheckboxElements_ContentItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckboxElements_Items_ContentItemId",
                table: "CheckboxElements",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DateTimeOffsetElements_Items_ContentItemId",
                table: "DateTimeOffsetElements",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IntegerElements_Items_ContentItemId",
                table: "IntegerElements",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Collections_ContentCollectionId",
                table: "Items",
                column: "ContentCollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownElements_Items_ContentItemId",
                table: "MarkdownElements",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NameFields_Collections_ContentCollectionId",
                table: "NameFields",
                column: "ContentCollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StringElements_Items_ContentItemId",
                table: "StringElements",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckboxElements_Items_ContentItemId",
                table: "CheckboxElements");

            migrationBuilder.DropForeignKey(
                name: "FK_DateTimeOffsetElements_Items_ContentItemId",
                table: "DateTimeOffsetElements");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegerElements_Items_ContentItemId",
                table: "IntegerElements");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Collections_ContentCollectionId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkdownElements_Items_ContentItemId",
                table: "MarkdownElements");

            migrationBuilder.DropForeignKey(
                name: "FK_NameFields_Collections_ContentCollectionId",
                table: "NameFields");

            migrationBuilder.DropForeignKey(
                name: "FK_StringElements_Items_ContentItemId",
                table: "StringElements");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "StringElements",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_StringElements_ContentItemId",
                table: "StringElements",
                newName: "IX_StringElements_ItemId");

            migrationBuilder.RenameColumn(
                name: "ContentCollectionId",
                table: "NameFields",
                newName: "CollectionId");

            migrationBuilder.RenameIndex(
                name: "IX_NameFields_ContentCollectionId",
                table: "NameFields",
                newName: "IX_NameFields_CollectionId");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "MarkdownElements",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_MarkdownElements_ContentItemId",
                table: "MarkdownElements",
                newName: "IX_MarkdownElements_ItemId");

            migrationBuilder.RenameColumn(
                name: "ContentCollectionId",
                table: "Items",
                newName: "CollectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ContentCollectionId",
                table: "Items",
                newName: "IX_Items_CollectionId");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "IntegerElements",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_IntegerElements_ContentItemId",
                table: "IntegerElements",
                newName: "IX_IntegerElements_ItemId");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "DateTimeOffsetElements",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_DateTimeOffsetElements_ContentItemId",
                table: "DateTimeOffsetElements",
                newName: "IX_DateTimeOffsetElements_ItemId");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "CheckboxElements",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckboxElements_ContentItemId",
                table: "CheckboxElements",
                newName: "IX_CheckboxElements_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckboxElements_Items_ItemId",
                table: "CheckboxElements",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DateTimeOffsetElements_Items_ItemId",
                table: "DateTimeOffsetElements",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IntegerElements_Items_ItemId",
                table: "IntegerElements",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Collections_CollectionId",
                table: "Items",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownElements_Items_ItemId",
                table: "MarkdownElements",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NameFields_Collections_CollectionId",
                table: "NameFields",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StringElements_Items_ItemId",
                table: "StringElements",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
