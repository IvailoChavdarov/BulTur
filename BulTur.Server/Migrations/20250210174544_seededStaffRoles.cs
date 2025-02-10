using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulTur.Server.Migrations
{
    /// <inheritdoc />
    public partial class seededStaffRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32066165-0fca-49b2-801d-fd4517b6d5db", null, "Writer", "WRITER" },
                    { "4e072768-3a78-4cc4-8d63-7ae87aaa5cae", null, "Editor", "EDITOR" },
                    { "fc012751-2557-4a1c-98aa-d1d8dd7b4ff5", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32066165-0fca-49b2-801d-fd4517b6d5db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e072768-3a78-4cc4-8d63-7ae87aaa5cae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc012751-2557-4a1c-98aa-d1d8dd7b4ff5");
        }
    }
}
