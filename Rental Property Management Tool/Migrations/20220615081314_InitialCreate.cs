using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental_Property_Management_Tool.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalEntity = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentalProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SquaresMeters = table.Column<double>(type: "float", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rented = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    RentalStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RentalEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    PersonsId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentalProperties_Persons_PersonsId",
                        column: x => x.PersonsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RentalProperties_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OverheadCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RentalPropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverheadCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadCosts_RentalProperties_RentalPropertyId",
                        column: x => x.RentalPropertyId,
                        principalTable: "RentalProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OverheadCosts_RentalPropertyId",
                table: "OverheadCosts",
                column: "RentalPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalProperties_PersonsId",
                table: "RentalProperties",
                column: "PersonsId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalProperties_UserId",
                table: "RentalProperties",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OverheadCosts");

            migrationBuilder.DropTable(
                name: "RentalProperties");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
