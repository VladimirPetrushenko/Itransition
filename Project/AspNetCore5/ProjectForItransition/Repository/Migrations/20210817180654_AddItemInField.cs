using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Repository.Migrations
{
    public partial class AddItemInField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_MarkdownElements_Items_ContentItemId",
                table: "MarkdownElements");

            migrationBuilder.DropForeignKey(
                name: "FK_StringElements_Items_ContentItemId",
                table: "StringElements");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Items_ContentItemId",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "Tags",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_ContentItemId",
                table: "Tags",
                newName: "IX_Tags_ItemId");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "StringElements",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_StringElements_ContentItemId",
                table: "StringElements",
                newName: "IX_StringElements_ItemId");

            migrationBuilder.RenameColumn(
                name: "ContentItemId",
                table: "MarkdownElements",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_MarkdownElements_ContentItemId",
                table: "MarkdownElements",
                newName: "IX_MarkdownElements_ItemId");

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "StringElements",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "MarkdownElements",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Comment",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Collections",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                name: "FK_MarkdownElements_Items_ItemId",
                table: "MarkdownElements",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StringElements_Items_ItemId",
                table: "StringElements",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Items_ItemId",
                table: "Tags",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_MarkdownElements_Items_ItemId",
                table: "MarkdownElements");

            migrationBuilder.DropForeignKey(
                name: "FK_StringElements_Items_ItemId",
                table: "StringElements");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Items_ItemId",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Tags",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_ItemId",
                table: "Tags",
                newName: "IX_Tags_ContentItemId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "StringElements",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_StringElements_ItemId",
                table: "StringElements",
                newName: "IX_StringElements_ContentItemId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "MarkdownElements",
                newName: "ContentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_MarkdownElements_ItemId",
                table: "MarkdownElements",
                newName: "IX_MarkdownElements_ContentItemId");

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "StringElements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "MarkdownElements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldNullable: true);

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
                name: "FK_MarkdownElements_Items_ContentItemId",
                table: "MarkdownElements",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StringElements_Items_ContentItemId",
                table: "StringElements",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Items_ContentItemId",
                table: "Tags",
                column: "ContentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
