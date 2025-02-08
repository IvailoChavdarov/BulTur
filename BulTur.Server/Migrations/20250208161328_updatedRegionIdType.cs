using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulTur.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedRegionIdType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the primary key
            migrationBuilder.DropPrimaryKey(
                name: "PK_Regions",
                table: "Regions");

            // Alter the column type
            migrationBuilder.AlterColumn<short>(
                name: "Id",
                table: "Regions",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            // Re-add the primary key with the new column type
            migrationBuilder.AddPrimaryKey(
                name: "PK_Regions",
                table: "Regions",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the primary key
            migrationBuilder.DropPrimaryKey(
                name: "PK_Regions",
                table: "Regions");

            // Revert the column type
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Regions",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            // Re-add the primary key with the original column type
            migrationBuilder.AddPrimaryKey(
                name: "PK_Regions",
                table: "Regions",
                column: "Id");
        }
    }
}