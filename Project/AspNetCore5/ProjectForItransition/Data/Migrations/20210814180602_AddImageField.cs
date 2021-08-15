﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForItransition.Data.Migrations
{
    public partial class AddImageField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Collections",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Collections_ImageId",
                table: "Collections",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_Images_ImageId",
                table: "Collections",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_Images_ImageId",
                table: "Collections");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Collections_ImageId",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Collections");
        }
    }
}
