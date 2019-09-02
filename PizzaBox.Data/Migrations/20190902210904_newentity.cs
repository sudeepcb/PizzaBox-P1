using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class newentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    addressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.addressId);
                });

            migrationBuilder.CreateTable(
                name: "Crusts",
                columns: table => new
                {
                    crustId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crusts", x => x.crustId);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    sizeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.sizeId);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    toppingsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.toppingsId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    locationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    addressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.locationId);
                    table.ForeignKey(
                        name: "FK_Locations_Addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "Addresses",
                        principalColumn: "addressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userName = table.Column<string>(nullable: false),
                    recentAddressaddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_recentAddressaddressId",
                        column: x => x.recentAddressaddressId,
                        principalTable: "Addresses",
                        principalColumn: "addressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    totalPrice = table.Column<decimal>(nullable: false),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_Orders_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomPizzas",
                columns: table => new
                {
                    CustomPizzaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    crustId = table.Column<int>(nullable: true),
                    sizeId = table.Column<int>(nullable: true),
                    toppingsId = table.Column<int>(nullable: true),
                    orderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomPizzas", x => x.CustomPizzaId);
                    table.ForeignKey(
                        name: "FK_CustomPizzas_Crusts_crustId",
                        column: x => x.crustId,
                        principalTable: "Crusts",
                        principalColumn: "crustId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomPizzas_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomPizzas_Sizes_sizeId",
                        column: x => x.sizeId,
                        principalTable: "Sizes",
                        principalColumn: "sizeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomPizzas_Toppings_toppingsId",
                        column: x => x.toppingsId,
                        principalTable: "Toppings",
                        principalColumn: "toppingsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderHistories",
                columns: table => new
                {
                    orderHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userId = table.Column<int>(nullable: true),
                    orderId = table.Column<int>(nullable: true),
                    locationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHistories", x => x.orderHistoryId);
                    table.ForeignKey(
                        name: "FK_OrderHistories_Locations_locationId",
                        column: x => x.locationId,
                        principalTable: "Locations",
                        principalColumn: "locationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderHistories_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderHistories_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Street",
                table: "Addresses",
                column: "Street",
                unique: true,
                filter: "[Street] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Crusts_Name",
                table: "Crusts",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzas_crustId",
                table: "CustomPizzas",
                column: "crustId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzas_orderId",
                table: "CustomPizzas",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzas_sizeId",
                table: "CustomPizzas",
                column: "sizeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzas_toppingsId",
                table: "CustomPizzas",
                column: "toppingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_addressId",
                table: "Locations",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistories_locationId",
                table: "OrderHistories",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistories_orderId",
                table: "OrderHistories",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistories_userId",
                table: "OrderHistories",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_userId",
                table: "Orders",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_Name",
                table: "Sizes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_Name",
                table: "Toppings",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_recentAddressaddressId",
                table: "Users",
                column: "recentAddressaddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_userName",
                table: "Users",
                column: "userName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomPizzas");

            migrationBuilder.DropTable(
                name: "OrderHistories");

            migrationBuilder.DropTable(
                name: "Crusts");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
