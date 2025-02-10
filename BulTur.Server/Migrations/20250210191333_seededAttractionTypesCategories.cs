using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulTur.Server.Migrations
{
    /// <inheritdoc />
    public partial class seededAttractionTypesCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AttractionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BannerImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconBannerImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttractionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attraction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BannerImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TownId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WriterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clicks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attraction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attraction_AttractionTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AttractionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attraction_Town_TownId",
                        column: x => x.TownId,
                        principalTable: "Town",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttractionImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttractionId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttractionImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttractionImages_Attraction_AttractionId",
                        column: x => x.AttractionId,
                        principalTable: "Attraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AttractionTypes",
                columns: new[] { "Id", "BannerImageUrl", "IconBannerImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "https://bulgariatravel.org/wp-content/uploads/2024/05/Lifestyle-and-Culture_bulgariatravel.org_-min-min.jpg", null, "Cultural" },
                    { 2, "https://i.ytimg.com/vi/YE6M1Rz9jSc/maxresdefault.jpg", null, "Historical" },
                    { 3, "https://prod0mobileapp.blob.core.windows.net/facilities/facilities/bg/3487/images/3_3487_2_FacilityPhoto.jpg?79215499", null, "Sports" },
                    { 4, "https://www.andrey-andreev.com/wp-content/uploads/2023/11/ABA00794-Edit.jpg", null, "Restaurants" },
                    { 5, "https://i0.wp.com/Blog.FreeUniBG.eu/wp-content/uploads/2020/06/0bb0beb72ab8b30050628460b803f39f.jpg?fit=1920%2C900&ssl=1", null, "Night life" },
                    { 6, "https://forbesbulgaria.com/wp-content/uploads/2024/01/pretty-young-women-relaxing-on-the-deckchair-by-th-2023-11-27-05-33-03-utc.jpg", null, "Wellness & Relaxation" },
                    { 7, "https://img.capital.bg/shimg/zx952y526_2888885.jpg", null, "Urban" },
                    { 8, "https://central-hotel.com/wp-content/uploads/2016/11/Rila.jpg", null, "Religious & Spiritual" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attraction_TownId",
                table: "Attraction",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_Attraction_TypeId",
                table: "Attraction",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttractionImages_AttractionId",
                table: "AttractionImages",
                column: "AttractionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Town_Regions_RegionId",
                table: "Town",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Town_Regions_RegionId",
                table: "Town");

            migrationBuilder.DropTable(
                name: "AttractionImages");

            migrationBuilder.DropTable(
                name: "Attraction");

            migrationBuilder.DropTable(
                name: "AttractionTypes");

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
    }
}
