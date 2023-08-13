using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig1312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Categories",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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
                columns: new[] { "CreatedDate", "LastModifiedDate", "Slug" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(786), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(786), "category-1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Slug" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(796), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(796), "category-2" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Slug" },
                values: new object[] { new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(797), new DateTime(2023, 8, 13, 12, 44, 43, 145, DateTimeKind.Utc).AddTicks(797), "category-3" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Categories",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 779, DateTimeKind.Utc).AddTicks(9597), new DateTime(2023, 5, 19, 10, 35, 50, 779, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 779, DateTimeKind.Utc).AddTicks(9603), new DateTime(2023, 5, 19, 10, 35, 50, 779, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 779, DateTimeKind.Utc).AddTicks(9607), new DateTime(2023, 5, 19, 10, 35, 50, 779, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Slug" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(235), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(236), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Slug" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(263), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(263), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Slug" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(268), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(268), null });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(278), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(281), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(283), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(285), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(288), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(408), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(411), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(413), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(416), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(419), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(422), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(425), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(431), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(433), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(436), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(439), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(348), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(353), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(356), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(358), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(360), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(630), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(633), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(635), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(692), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(615), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(484), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(488), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(490), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(554), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(561), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(565), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(567), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(570), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(503), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(507), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(507) });
        }
    }
}
