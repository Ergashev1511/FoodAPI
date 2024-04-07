using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FoodAPI.Migrations
{
    /// <inheritdoc />
    public partial class firts_migrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Info = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    mail = table.Column<int>(type: "integer", nullable: false),
                    IsCreated = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    IsCreated = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orderInFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    foodsId = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: true),
                    IsCreated = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderInFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orderInFoods_foods_foodsId",
                        column: x => x.foodsId,
                        principalTable: "foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderInFoods_order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Info = table.Column<string>(type: "text", nullable: false),
                    orderId = table.Column<int>(type: "integer", nullable: true),
                    IsCreated = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tables_order_orderId",
                        column: x => x.orderId,
                        principalTable: "order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_orderInFoods_foodsId",
                table: "orderInFoods",
                column: "foodsId");

            migrationBuilder.CreateIndex(
                name: "IX_orderInFoods_OrderId",
                table: "orderInFoods",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_tables_orderId",
                table: "tables",
                column: "orderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderInFoods");

            migrationBuilder.DropTable(
                name: "tables");

            migrationBuilder.DropTable(
                name: "foods");

            migrationBuilder.DropTable(
                name: "order");
        }
    }
}
