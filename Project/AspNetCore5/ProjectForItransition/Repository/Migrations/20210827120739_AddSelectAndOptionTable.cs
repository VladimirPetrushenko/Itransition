using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Repository.Migrations
{
    public partial class AddSelectAndOptionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SelectElements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentCollectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectElements_Collections_ContentCollectionId",
                        column: x => x.ContentCollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OptionElements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    SelectElementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionElements_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OptionElements_SelectElements_SelectElementId",
                        column: x => x.SelectElementId,
                        principalTable: "SelectElements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OptionElements_ItemId",
                table: "OptionElements",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionElements_SelectElementId",
                table: "OptionElements",
                column: "SelectElementId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectElements_ContentCollectionId",
                table: "SelectElements",
                column: "ContentCollectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OptionElements");

            migrationBuilder.DropTable(
                name: "SelectElements");
        }
    }
}
