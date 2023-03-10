using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BussinessManagementApp.DataAccess.Migrations.BussinesManagementDb
{
    public partial class hasIndexUpdatedForSupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Suppliers_TelNo",
                table: "Suppliers");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_TelNo",
                table: "Suppliers",
                column: "TelNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Suppliers_TelNo",
                table: "Suppliers");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Suppliers_TelNo",
                table: "Suppliers",
                column: "TelNo");
        }
    }
}
