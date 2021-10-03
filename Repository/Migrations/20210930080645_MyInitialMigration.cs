using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class MyInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SportsBet",
                columns: table => new
                {
                    BetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Odds = table.Column<double>(type: "float", nullable: false),
                    Competition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsBet", x => x.BetId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SportsBet");
        }
    }
}
