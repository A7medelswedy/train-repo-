using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignmentt.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "OrderViewModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "OrderViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Quantities",
                table: "OrderViewModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "OrderViewModel",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "OrderDetailsViewModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "OrderViewModel");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "OrderViewModel");

            migrationBuilder.DropColumn(
                name: "Quantities",
                table: "OrderViewModel");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "OrderViewModel");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "OrderDetailsViewModel");
        }
    }
}
