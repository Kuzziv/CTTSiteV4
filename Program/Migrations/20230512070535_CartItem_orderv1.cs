using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTTSite.Migrations
{
    /// <inheritdoc />
    public partial class CartItem_orderv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Order_CartItems_CartItemID",
                table: "CartItem_Order");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Order_Order_OrderID",
                table: "CartItem_Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItem_Order",
                table: "CartItem_Order");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_Order_CartItemID",
                table: "CartItem_Order");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_Order_OrderID",
                table: "CartItem_Order");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "CartItem_Order",
                newName: "CartItem_Orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItem_Orders",
                table: "CartItem_Orders",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItem_Orders",
                table: "CartItem_Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "CartItem_Orders",
                newName: "CartItem_Order");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItem_Order",
                table: "CartItem_Order",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_Order_CartItemID",
                table: "CartItem_Order",
                column: "CartItemID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_Order_OrderID",
                table: "CartItem_Order",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Order_CartItems_CartItemID",
                table: "CartItem_Order",
                column: "CartItemID",
                principalTable: "CartItems",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Order_Order_OrderID",
                table: "CartItem_Order",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
