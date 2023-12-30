using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazineAPI.Persistence.Migrations
{
    public partial class Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Magazines",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Magazines_AppUserId",
                table: "Magazines",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Magazines_AspNetUsers_AppUserId",
                table: "Magazines",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Magazines_AspNetUsers_AppUserId",
                table: "Magazines");

            migrationBuilder.DropIndex(
                name: "IX_Magazines_AppUserId",
                table: "Magazines");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Magazines");
        }
    }
}
