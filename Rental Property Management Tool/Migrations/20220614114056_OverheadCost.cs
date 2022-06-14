using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental_Property_Management_Tool.Migrations
{
    public partial class OverheadCost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OverheadCosts_RentalProperties_RentalPropertyId",
                table: "OverheadCosts");

            migrationBuilder.AlterColumn<int>(
                name: "RentalPropertyId",
                table: "OverheadCosts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OverheadCosts_RentalProperties_RentalPropertyId",
                table: "OverheadCosts",
                column: "RentalPropertyId",
                principalTable: "RentalProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OverheadCosts_RentalProperties_RentalPropertyId",
                table: "OverheadCosts");

            migrationBuilder.AlterColumn<int>(
                name: "RentalPropertyId",
                table: "OverheadCosts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OverheadCosts_RentalProperties_RentalPropertyId",
                table: "OverheadCosts",
                column: "RentalPropertyId",
                principalTable: "RentalProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
