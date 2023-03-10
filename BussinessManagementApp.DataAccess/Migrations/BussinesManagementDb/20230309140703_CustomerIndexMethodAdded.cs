using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BussinessManagementApp.DataAccess.Migrations.BussinesManagementDb
{
    public partial class CustomerIndexMethodAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Customers_Email",
                table: "Customers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Customers_TelNo",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                table: "Customers",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TelNo",
                table: "Customers",
                column: "TelNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_Email",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TelNo",
                table: "Customers");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Customers_Email",
                table: "Customers",
                column: "Email");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Customers_TelNo",
                table: "Customers",
                column: "TelNo");
        }
    }
}
