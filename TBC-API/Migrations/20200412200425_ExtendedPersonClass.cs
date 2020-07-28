using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TBC_API.Migrations
{
    public partial class ExtendedPersonClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "City",
                table: "PPerson",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "PPerson",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "PPerson",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IDNunmber",
                table: "PPerson",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "PPerson",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneType",
                table: "PPerson",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "PPerson",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropColumn(
                name: "City",
                table: "PPerson");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "PPerson");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "PPerson");

            migrationBuilder.DropColumn(
                name: "IDNunmber",
                table: "PPerson");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "PPerson");

            migrationBuilder.DropColumn(
                name: "PhoneType",
                table: "PPerson");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "PPerson");
        }
    }
}
