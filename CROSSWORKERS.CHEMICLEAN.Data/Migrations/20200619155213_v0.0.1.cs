using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CROSSWORKERS.CHEMICLEAN.Data.Migrations
{
    public partial class v001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "tblProduct",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "tblProduct",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "tblProduct",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SafetyDataSheetPath",
                table: "tblProduct",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblProduct",
                table: "tblProduct",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblProduct",
                table: "tblProduct");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "tblProduct");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "tblProduct");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "tblProduct");

            migrationBuilder.DropColumn(
                name: "SafetyDataSheetPath",
                table: "tblProduct");
        }
    }
}
