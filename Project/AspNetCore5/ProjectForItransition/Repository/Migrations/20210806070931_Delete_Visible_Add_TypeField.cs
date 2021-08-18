using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Repository.Migrations
{
    public partial class Delete_Visible_Add_TypeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisibleElements_Collections_CollectionId",
                table: "VisibleElements");

            migrationBuilder.DropIndex(
                name: "IX_VisibleElements_CollectionId",
                table: "VisibleElements");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "VisibleElements");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "NameFields",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "NameFields");

            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "VisibleElements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisibleElements_CollectionId",
                table: "VisibleElements",
                column: "CollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisibleElements_Collections_CollectionId",
                table: "VisibleElements",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
