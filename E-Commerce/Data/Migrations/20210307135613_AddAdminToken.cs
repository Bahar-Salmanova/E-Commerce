using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddAdminToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PermissionsId",
                table: "CustomerUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerUserId",
                table: "BasketItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuperAdminId",
                table: "BasketItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "AdminUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerUsers_PermissionsId",
                table: "CustomerUsers",
                column: "PermissionsId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_CustomerUserId",
                table: "BasketItem",
                column: "CustomerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_SuperAdminId",
                table: "BasketItem",
                column: "SuperAdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_CustomerUsers_CustomerUserId",
                table: "BasketItem",
                column: "CustomerUserId",
                principalTable: "CustomerUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_SuperAdmin_SuperAdminId",
                table: "BasketItem",
                column: "SuperAdminId",
                principalTable: "SuperAdmin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerUsers_Permissions_PermissionsId",
                table: "CustomerUsers",
                column: "PermissionsId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_CustomerUsers_CustomerUserId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_SuperAdmin_SuperAdminId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerUsers_Permissions_PermissionsId",
                table: "CustomerUsers");

            migrationBuilder.DropIndex(
                name: "IX_CustomerUsers_PermissionsId",
                table: "CustomerUsers");

            migrationBuilder.DropIndex(
                name: "IX_BasketItem_CustomerUserId",
                table: "BasketItem");

            migrationBuilder.DropIndex(
                name: "IX_BasketItem_SuperAdminId",
                table: "BasketItem");

            migrationBuilder.DropColumn(
                name: "PermissionsId",
                table: "CustomerUsers");

            migrationBuilder.DropColumn(
                name: "CustomerUserId",
                table: "BasketItem");

            migrationBuilder.DropColumn(
                name: "SuperAdminId",
                table: "BasketItem");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "AdminUsers");
        }
    }
}
