using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amazon.Context.Migrations
{
    /// <inheritdoc />
    public partial class addtotoaltoorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "total",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "total",
                table: "Orders");
        }
    }
}
