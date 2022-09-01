using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bartender.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BarMenue",
                columns: table => new
                {
                    CocktailID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CocktailName = table.Column<string>(type: "TEXT", nullable: true),
                    CocktailDescription = table.Column<string>(type: "TEXT", nullable: true),
                    CocktailPrice = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarMenue", x => x.CocktailID);
                });

            migrationBuilder.CreateTable(
                name: "BarQueue",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CocktailID = table.Column<int>(type: "INTEGER", nullable: false),
                    CocktailName = table.Column<string>(type: "TEXT", nullable: false),
                    CocktailDescription = table.Column<string>(type: "TEXT", nullable: true),
                    OrderTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarQueue", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "BarStaff",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StaffUsername = table.Column<string>(type: "TEXT", nullable: false),
                    StaffPassword = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarStaff", x => x.StaffID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarMenue");

            migrationBuilder.DropTable(
                name: "BarQueue");

            migrationBuilder.DropTable(
                name: "BarStaff");
        }
    }
}
