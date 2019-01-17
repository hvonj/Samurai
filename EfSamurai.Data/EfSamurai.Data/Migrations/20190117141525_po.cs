using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class po : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleEvents_Battle_BattleId",
                table: "BattleEvents");

            migrationBuilder.DropIndex(
                name: "IX_BattleEvents_BattleId",
                table: "BattleEvents");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "BattleEvents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "BattleEvents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BattleEvents_BattleId",
                table: "BattleEvents",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleEvents_Battle_BattleId",
                table: "BattleEvents",
                column: "BattleId",
                principalTable: "Battle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
