using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealTimeAggregator.Data.Purchase.Migrations
{
    /// <inheritdoc />
    public partial class ddd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductID",
                table: "PurchaseOrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "PurchaseOrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "PurchaseOrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
