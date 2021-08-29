using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Repository.Migrations
{
    public partial class createManyToManyItemOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OptionElements_Items_ItemId",
                table: "OptionElements");

            migrationBuilder.DropIndex(
                name: "IX_OptionElements_ItemId",
                table: "OptionElements");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "OptionElements");

            migrationBuilder.CreateTable(
                name: "ContentItemOptionElement",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    OptionElementsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentItemOptionElement", x => new { x.ItemId, x.OptionElementsId });
                    table.ForeignKey(
                        name: "FK_ContentItemOptionElement_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentItemOptionElement_OptionElements_OptionElementsId",
                        column: x => x.OptionElementsId,
                        principalTable: "OptionElements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContentItemOptionElement_OptionElementsId",
                table: "ContentItemOptionElement",
                column: "OptionElementsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentItemOptionElement");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "OptionElements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OptionElements_ItemId",
                table: "OptionElements",
                column: "ItemId");

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
