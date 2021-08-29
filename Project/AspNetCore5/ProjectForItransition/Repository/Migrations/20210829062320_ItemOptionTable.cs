using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Repository.Migrations
{
    public partial class ItemOptionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentItemOptionElement");

            migrationBuilder.CreateTable(
                name: "ItemOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    OptionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemOptions_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemOptions_OptionElements_OptionId",
                        column: x => x.OptionId,
                        principalTable: "OptionElements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemOptions_ItemId",
                table: "ItemOptions",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOptions_OptionId",
                table: "ItemOptions",
                column: "OptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemOptions");

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
    }
}
