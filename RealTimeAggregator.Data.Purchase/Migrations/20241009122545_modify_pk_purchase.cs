using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealTimeAggregator.Data.Purchase.Migrations
{
    /// <inheritdoc />
    public partial class modify_pk_purchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WarehouseID",
                table: "Warehouses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "Suppliers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ReceivingID",
                table: "ReceivingLogs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "QualityControlID",
                table: "QualityControls",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PurchasePriceID",
                table: "PurchasePrices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PurchaseOrderID",
                table: "PurchaseOrders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PurchaseOrderDetailID",
                table: "PurchaseOrderDetails",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Warehouses",
                newName: "WarehouseID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Suppliers",
                newName: "SupplierID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ReceivingLogs",
                newName: "ReceivingID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "QualityControls",
                newName: "QualityControlID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PurchasePrices",
                newName: "PurchasePriceID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PurchaseOrders",
                newName: "PurchaseOrderID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PurchaseOrderDetails",
                newName: "PurchaseOrderDetailID");
        }
    }
}
