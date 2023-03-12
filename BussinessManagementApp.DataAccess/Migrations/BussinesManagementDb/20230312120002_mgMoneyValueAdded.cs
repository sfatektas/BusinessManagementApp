using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BussinessManagementApp.DataAccess.Migrations.BussinesManagementDb
{
    public partial class mgMoneyValueAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MoneyTypeValue",
                table: "SupplierOrders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoneyTypeValue",
                table: "SupplierOrders");
        }
    }
}
