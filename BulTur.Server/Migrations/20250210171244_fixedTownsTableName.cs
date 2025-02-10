using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulTur.Server.Migrations
{
    /// <inheritdoc />
    public partial class fixedTownsTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Town_Regions_RegionId",
                table: "Town");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Town",
                table: "Town");

            migrationBuilder.RenameTable(
                name: "Town",
                newName: "Towns");

            migrationBuilder.RenameIndex(
                name: "IX_Town_RegionId",
                table: "Towns",
                newName: "IX_Towns_RegionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Towns",
                table: "Towns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Regions_RegionId",
                table: "Towns",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Regions_RegionId",
                table: "Towns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Towns",
                table: "Towns");

            migrationBuilder.RenameTable(
                name: "Towns",
                newName: "Town");

            migrationBuilder.RenameIndex(
                name: "IX_Towns_RegionId",
                table: "Town",
                newName: "IX_Town_RegionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Town",
                table: "Town",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Town_Regions_RegionId",
                table: "Town",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
