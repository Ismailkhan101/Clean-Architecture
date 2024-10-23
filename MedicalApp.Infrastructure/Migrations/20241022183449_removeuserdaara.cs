using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeuserdaara : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StockQuantity",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Users",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "StockQuantity",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
