using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulTur.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedRegionsCoatOfArmsField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoatOfArmsImageUrl",
                table: "Regions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "CoatOfArmsImageUrl",
                value: "https://podkrepa.org/wp-content/uploads/2021/06/%D0%91%D0%BB%D0%B0%D0%B3%D0%BE%D0%B5%D0%B2%D0%B3%D1%80%D0%B0%D0%B4.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ce/Burgas-coat-of-arms.svg/1200px-Burgas-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "CoatOfArmsImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXKQ2kiaqDIVPRue8o9kmFvo_05aEf9lgTaUKSJ67uyZwxBynb41GWPJzDzZuOZIVnT90&usqp=CAU");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Veliko-Tarnovo-coat-of-arms.svg/724px-Veliko-Tarnovo-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Coat_of_arms_of_Vidin.svg/1535px-Coat_of_arms_of_Vidin.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)6,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Vratsa-coat-of-arms.svg/1200px-Vratsa-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)7,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/BG_Gabrovo_coa.svg/1584px-BG_Gabrovo_coa.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)8,
                column: "CoatOfArmsImageUrl",
                value: "https://www.dobrich.bg/uploads/pages/2023/5aae631485b57f4dba5d3477023f4e1f.gif");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)9,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9d/Kardzhali-coat-of-arms.svg/791px-Kardzhali-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)10,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/d/d3/Kyustendil-coat-of-arms.svg");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)11,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Lovech-coat-of-arms.svg/1535px-Lovech-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)12,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/3/31/Coat_of_Arms_of_Montana_%28Bulgaria%29.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)13,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Emblem_of_Pazardzhik.svg/1200px-Emblem_of_Pazardzhik.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)14,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Pernik-coat-of-arms.svg/1200px-Pernik-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)15,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Pleven-coat-of-arms.svg/724px-Pleven-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)16,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/5/55/Plovdiv-coat-of-arms.svg/1448px-Plovdiv-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)17,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/c/cc/Emblem_of_Razgrad.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)18,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Rousse-coat-of-arms.svg/800px-Rousse-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)19,
                column: "CoatOfArmsImageUrl",
                value: "https://e-gover.net/images/uploads/pictures/img_2_institution_normal_0.jpeg");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)20,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Updated_coat_of_arms_of_Sliven.png/250px-Updated_coat_of_arms_of_Sliven.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)21,
                column: "CoatOfArmsImageUrl",
                value: "https://toppresa.com/wp-content/uploads/2022/04/%D1%81%D0%BC%D0%BE%D0%BB%D1%8F%D0%BD-%D0%BB%D0%BE%D0%B3%D0%BE.jpg");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)22,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/BG_Sofia_coa.svg/1200px-BG_Sofia_coa.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)23,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/BG_Sofia_coa.svg/1200px-BG_Sofia_coa.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)24,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Stara-Zagora-coat-of-arms.svg/250px-Stara-Zagora-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)25,
                column: "CoatOfArmsImageUrl",
                value: "https://epi-bg.org/images/municipality/Logos/logo_targovishte.jpg");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)26,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Haskovo-coat-of-arms.svg/1200px-Haskovo-coat-of-arms.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)27,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Emblem_of_Shumen.svg/1658px-Emblem_of_Shumen.svg.png");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)28,
                column: "CoatOfArmsImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/The_symbol_of_Yambol_city.svg/1524px-The_symbol_of_Yambol_city.svg.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoatOfArmsImageUrl",
                table: "Regions");
        }
    }
}
