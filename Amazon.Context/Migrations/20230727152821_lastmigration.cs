using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amazon.Context.Migrations
{
    /// <inheritdoc />
    public partial class lastmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ShippingAddresses_shippingAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_shippingAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "shippingAddressId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "buildNumber",
                table: "ShippingAddresses",
                newName: "buildname");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "ShippingAddresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ShippingAddresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "ShippingAddresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userid",
                table: "ShippingAddresses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_CityId",
                table: "ShippingAddresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_userid",
                table: "ShippingAddresses",
                column: "userid");

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingAddresses_AspNetUsers_userid",
                table: "ShippingAddresses",
                column: "userid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingAddresses_Cities_CityId",
                table: "ShippingAddresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShippingAddresses_AspNetUsers_userid",
                table: "ShippingAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingAddresses_Cities_CityId",
                table: "ShippingAddresses");

            migrationBuilder.DropIndex(
                name: "IX_ShippingAddresses_CityId",
                table: "ShippingAddresses");

            migrationBuilder.DropIndex(
                name: "IX_ShippingAddresses_userid",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "ShippingAddresses");

            migrationBuilder.RenameColumn(
                name: "buildname",
                table: "ShippingAddresses",
                newName: "buildNumber");

            migrationBuilder.AddColumn<int>(
                name: "shippingAddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_shippingAddressId",
                table: "AspNetUsers",
                column: "shippingAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ShippingAddresses_shippingAddressId",
                table: "AspNetUsers",
                column: "shippingAddressId",
                principalTable: "ShippingAddresses",
                principalColumn: "id");
        }
    }
}
