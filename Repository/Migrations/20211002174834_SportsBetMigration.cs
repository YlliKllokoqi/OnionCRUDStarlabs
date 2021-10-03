using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class SportsBetMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SportsBet",
                table: "SportsBet");

            migrationBuilder.RenameTable(
                name: "SportsBet",
                newName: "SportsBets");

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "SportsBets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Competition",
                table: "SportsBets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BetName",
                table: "SportsBets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SportsBets",
                table: "SportsBets",
                column: "BetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SportsBets",
                table: "SportsBets");

            migrationBuilder.RenameTable(
                name: "SportsBets",
                newName: "SportsBet");

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "SportsBet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Competition",
                table: "SportsBet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BetName",
                table: "SportsBet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SportsBet",
                table: "SportsBet",
                column: "BetId");
        }
    }
}
