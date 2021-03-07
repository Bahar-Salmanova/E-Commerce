using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Retry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperAdmin_Permissions_PermissionsId",
                table: "SuperAdmin");

            migrationBuilder.DropIndex(
                name: "IX_SuperAdmin_PermissionsId",
                table: "SuperAdmin");

            migrationBuilder.DropColumn(
                name: "PermissionsId",
                table: "SuperAdmin");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "AdminUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PermissionsId",
                table: "SuperAdmin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "AdminUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SuperAdmin_PermissionsId",
                table: "SuperAdmin",
                column: "PermissionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperAdmin_Permissions_PermissionsId",
                table: "SuperAdmin",
                column: "PermissionsId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
