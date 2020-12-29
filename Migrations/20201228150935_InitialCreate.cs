using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingCar.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Plate = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Entrance = table.Column<DateTime>(nullable: false),
                    Exit = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Plate);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
