using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ChangeSuperAdminToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_SuperAdmin_SuperAdminId",
                table: "BasketItem");

            migrationBuilder.DropIndex(
                name: "IX_BasketItem_SuperAdminId",
                table: "BasketItem");

            migrationBuilder.DropColumn(
                name: "SuperAdminId",
                table: "BasketItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SuperAdminId",
                table: "BasketItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_SuperAdminId",
                table: "BasketItem",
                column: "SuperAdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_SuperAdmin_SuperAdminId",
                table: "BasketItem",
                column: "SuperAdminId",
                principalTable: "SuperAdmin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
