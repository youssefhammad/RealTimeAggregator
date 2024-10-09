using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealTimeAggregator.Data.Sales.Migrations
{
    /// <inheritdoc />
    public partial class modify_pk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShippingID",
                table: "Shippings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SalesPersonID",
                table: "SalesPersons",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SalesOrderID",
                table: "SalesOrders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SalesOrderDetailID",
                table: "SalesOrderDetails",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PriceID",
                table: "ProductPrices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PaymentID",
                table: "Payments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DiscountID",
                table: "Discounts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customers",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Shippings",
                newName: "ShippingID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SalesPersons",
                newName: "SalesPersonID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SalesOrders",
                newName: "SalesOrderID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SalesOrderDetails",
                newName: "SalesOrderDetailID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductPrices",
                newName: "PriceID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Payments",
                newName: "PaymentID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Discounts",
                newName: "DiscountID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "CustomerID");
        }
    }
}
