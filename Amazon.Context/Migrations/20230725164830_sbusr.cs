using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amazon.Context.Migrations
{
    /// <inheritdoc />
    public partial class sbusr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingAddresses_shippingAddressId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "ProductRatings");

            migrationBuilder.RenameColumn(
                name: "Review",
                table: "Ratings",
                newName: "review");

            migrationBuilder.RenameColumn(
                name: "Star",
                table: "Ratings",
                newName: "rate");

            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "shippingAddressId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_productId",
                table: "Ratings",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingAddresses_shippingAddressId",
                table: "Orders",
                column: "shippingAddressId",
                principalTable: "ShippingAddresses",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Products_productId",
                table: "Ratings",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingAddresses_shippingAddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Products_productId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_productId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "userName",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "review",
                table: "Ratings",
                newName: "Review");

            migrationBuilder.RenameColumn(
                name: "rate",
                table: "Ratings",
                newName: "Star");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Products",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "shippingAddressId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProductRatings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<int>(type: "int", nullable: false),
                    Ratingid = table.Column<int>(type: "int", nullable: false),
                    rateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRatings", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductRatings_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductRatings_Ratings_Ratingid",
                        column: x => x.Ratingid,
                        principalTable: "Ratings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductRatings_productId",
                table: "ProductRatings",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRatings_Ratingid",
                table: "ProductRatings",
                column: "Ratingid");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingAddresses_shippingAddressId",
                table: "Orders",
                column: "shippingAddressId",
                principalTable: "ShippingAddresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
