using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class newentity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomPizzas_Toppings_toppingsId",
                table: "CustomPizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_recentAddressaddressId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_CustomPizzas_toppingsId",
                table: "CustomPizzas");

            migrationBuilder.DropColumn(
                name: "toppingsId",
                table: "CustomPizzas");

            migrationBuilder.RenameColumn(
                name: "recentAddressaddressId",
                table: "Users",
                newName: "addressId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_recentAddressaddressId",
                table: "Users",
                newName: "IX_Users_addressId");

            migrationBuilder.AddColumn<int>(
                name: "CustomPizzaId",
                table: "Toppings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_CustomPizzaId",
                table: "Toppings",
                column: "CustomPizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_CustomPizzas_CustomPizzaId",
                table: "Toppings",
                column: "CustomPizzaId",
                principalTable: "CustomPizzas",
                principalColumn: "CustomPizzaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_addressId",
                table: "Users",
                column: "addressId",
                principalTable: "Addresses",
                principalColumn: "addressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_CustomPizzas_CustomPizzaId",
                table: "Toppings");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_addressId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_CustomPizzaId",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "CustomPizzaId",
                table: "Toppings");

            migrationBuilder.RenameColumn(
                name: "addressId",
                table: "Users",
                newName: "recentAddressaddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_addressId",
                table: "Users",
                newName: "IX_Users_recentAddressaddressId");

            migrationBuilder.AddColumn<int>(
                name: "toppingsId",
                table: "CustomPizzas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzas_toppingsId",
                table: "CustomPizzas",
                column: "toppingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomPizzas_Toppings_toppingsId",
                table: "CustomPizzas",
                column: "toppingsId",
                principalTable: "Toppings",
                principalColumn: "toppingsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_recentAddressaddressId",
                table: "Users",
                column: "recentAddressaddressId",
                principalTable: "Addresses",
                principalColumn: "addressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
