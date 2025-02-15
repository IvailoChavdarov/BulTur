using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulTur.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedMapsEmbedUrlFieldForAttractions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MapsEmbedUrl",
                table: "Attractions",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MapsEmbedUrl",
                table: "Attractions");
        }
    }
}
