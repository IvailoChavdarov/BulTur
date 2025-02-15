using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulTur.Server.Migrations
{
    /// <inheritdoc />
    public partial class fixedAttractionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attraction_AttractionTypes_TypeId",
                table: "Attraction");

            migrationBuilder.DropForeignKey(
                name: "FK_Attraction_Town_TownId",
                table: "Attraction");

            migrationBuilder.DropForeignKey(
                name: "FK_AttractionImages_Attraction_AttractionId",
                table: "AttractionImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Town_Regions_RegionId",
                table: "Town");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Town",
                table: "Town");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attraction",
                table: "Attraction");

            migrationBuilder.RenameTable(
                name: "Town",
                newName: "Towns");

            migrationBuilder.RenameTable(
                name: "Attraction",
                newName: "Attractions");

            migrationBuilder.RenameIndex(
                name: "IX_Town_RegionId",
                table: "Towns",
                newName: "IX_Towns_RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Attraction_TypeId",
                table: "Attractions",
                newName: "IX_Attractions_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Attraction_TownId",
                table: "Attractions",
                newName: "IX_Attractions_TownId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Towns",
                table: "Towns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attractions",
                table: "Attractions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttractionImages_Attractions_AttractionId",
                table: "AttractionImages",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_AttractionTypes_TypeId",
                table: "Attractions",
                column: "TypeId",
                principalTable: "AttractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_Towns_TownId",
                table: "Attractions",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_AttractionImages_Attractions_AttractionId",
                table: "AttractionImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_AttractionTypes_TypeId",
                table: "Attractions");

            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_Towns_TownId",
                table: "Attractions");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Regions_RegionId",
                table: "Towns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Towns",
                table: "Towns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attractions",
                table: "Attractions");

            migrationBuilder.RenameTable(
                name: "Towns",
                newName: "Town");

            migrationBuilder.RenameTable(
                name: "Attractions",
                newName: "Attraction");

            migrationBuilder.RenameIndex(
                name: "IX_Towns_RegionId",
                table: "Town",
                newName: "IX_Town_RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Attractions_TypeId",
                table: "Attraction",
                newName: "IX_Attraction_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Attractions_TownId",
                table: "Attraction",
                newName: "IX_Attraction_TownId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Town",
                table: "Town",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attraction",
                table: "Attraction",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attraction_AttractionTypes_TypeId",
                table: "Attraction",
                column: "TypeId",
                principalTable: "AttractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attraction_Town_TownId",
                table: "Attraction",
                column: "TownId",
                principalTable: "Town",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttractionImages_Attraction_AttractionId",
                table: "AttractionImages",
                column: "AttractionId",
                principalTable: "Attraction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
