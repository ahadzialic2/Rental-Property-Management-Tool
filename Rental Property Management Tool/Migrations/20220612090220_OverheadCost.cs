using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental_Property_Management_Tool.Migrations
{
    public partial class OverheadCost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OverheadCostRentalProperty");

            migrationBuilder.AddColumn<int>(
                name: "RentalPropertyId",
                table: "OverheadCosts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OverheadCosts_RentalPropertyId",
                table: "OverheadCosts",
                column: "RentalPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_OverheadCosts_RentalProperties_RentalPropertyId",
                table: "OverheadCosts",
                column: "RentalPropertyId",
                principalTable: "RentalProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OverheadCosts_RentalProperties_RentalPropertyId",
                table: "OverheadCosts");

            migrationBuilder.DropIndex(
                name: "IX_OverheadCosts_RentalPropertyId",
                table: "OverheadCosts");

            migrationBuilder.DropColumn(
                name: "RentalPropertyId",
                table: "OverheadCosts");

            migrationBuilder.CreateTable(
                name: "OverheadCostRentalProperty",
                columns: table => new
                {
                    CostsId = table.Column<int>(type: "int", nullable: false),
                    RentalPropertiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverheadCostRentalProperty", x => new { x.CostsId, x.RentalPropertiesId });
                    table.ForeignKey(
                        name: "FK_OverheadCostRentalProperty_OverheadCosts_CostsId",
                        column: x => x.CostsId,
                        principalTable: "OverheadCosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OverheadCostRentalProperty_RentalProperties_RentalPropertiesId",
                        column: x => x.RentalPropertiesId,
                        principalTable: "RentalProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OverheadCostRentalProperty_RentalPropertiesId",
                table: "OverheadCostRentalProperty",
                column: "RentalPropertiesId");
        }
    }
}
