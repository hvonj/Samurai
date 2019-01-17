using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class de : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battle_BattleLog_BattleLogId",
                table: "Battle");

            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Samurais_SamuraiId",
                table: "Quote");

            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_SecretIdentity_SecretIdentityId",
                table: "Samurais");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_SecretIdentityId",
                table: "Samurais");

            migrationBuilder.DropIndex(
                name: "IX_Battle_BattleLogId",
                table: "Battle");

            migrationBuilder.DropColumn(
                name: "SecretIdentityId",
                table: "Samurais");

            migrationBuilder.AddColumn<int>(
                name: "SamuraiId",
                table: "SecretIdentity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SamuraiId",
                table: "Quote",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BattleLogId",
                table: "Battle",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Battle",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SecretIdentity_SamuraiId",
                table: "SecretIdentity",
                column: "SamuraiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Battle_BattleLogId",
                table: "Battle",
                column: "BattleLogId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Battle_BattleLog_BattleLogId",
                table: "Battle",
                column: "BattleLogId",
                principalTable: "BattleLog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Samurais_SamuraiId",
                table: "Quote",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecretIdentity_Samurais_SamuraiId",
                table: "SecretIdentity",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battle_BattleLog_BattleLogId",
                table: "Battle");

            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Samurais_SamuraiId",
                table: "Quote");

            migrationBuilder.DropForeignKey(
                name: "FK_SecretIdentity_Samurais_SamuraiId",
                table: "SecretIdentity");

            migrationBuilder.DropIndex(
                name: "IX_SecretIdentity_SamuraiId",
                table: "SecretIdentity");

            migrationBuilder.DropIndex(
                name: "IX_Battle_BattleLogId",
                table: "Battle");

            migrationBuilder.DropColumn(
                name: "SamuraiId",
                table: "SecretIdentity");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Battle");

            migrationBuilder.AddColumn<int>(
                name: "SecretIdentityId",
                table: "Samurais",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SamuraiId",
                table: "Quote",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BattleLogId",
                table: "Battle",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_SecretIdentityId",
                table: "Samurais",
                column: "SecretIdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_Battle_BattleLogId",
                table: "Battle",
                column: "BattleLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battle_BattleLog_BattleLogId",
                table: "Battle",
                column: "BattleLogId",
                principalTable: "BattleLog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Samurais_SamuraiId",
                table: "Quote",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_SecretIdentity_SecretIdentityId",
                table: "Samurais",
                column: "SecretIdentityId",
                principalTable: "SecretIdentity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
