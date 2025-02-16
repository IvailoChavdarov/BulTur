using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulTur.Server.Migrations
{
    /// <inheritdoc />
    public partial class connectedAttractionsAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WriterId",
                table: "Attractions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Attractions_WriterId",
                table: "Attractions",
                column: "WriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_AspNetUsers_WriterId",
                table: "Attractions",
                column: "WriterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_AspNetUsers_WriterId",
                table: "Attractions");

            migrationBuilder.DropIndex(
                name: "IX_Attractions_WriterId",
                table: "Attractions");

            migrationBuilder.AlterColumn<string>(
                name: "WriterId",
                table: "Attractions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
