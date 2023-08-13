using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig12312312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentCategories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8163), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8166), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8167), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8284), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8297), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8298), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8304), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8305), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8306), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8306), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8307), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8343), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8345), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8346), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8347), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8348), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8349), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8351), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8352), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8353), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8354), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8328), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8329), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8330), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8331), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8331), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8413), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8414), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8415), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8428), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8408), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8367), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8368), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8369), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8389), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8390), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8392), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8392), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8394), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8372), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8372), new DateTime(2023, 8, 13, 13, 41, 51, 893, DateTimeKind.Utc).AddTicks(8373) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentCategories");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(682), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(686), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(687), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(786), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(796), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(797), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(802), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(803), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(804), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(805), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(806), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(839), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(840), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(841), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(842), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(843), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(844), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(845), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(846), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(847), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(848), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(849), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(824), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(825), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(826), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(827), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(827), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(936), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(937), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(938), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(952), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(933), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(889), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(890), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(890), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(915), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(917), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(918), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(919), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(920), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(897), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(898), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(898) });
        }
    }
}
