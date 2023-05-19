using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Categories",
                type: "text",
                nullable: true);

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
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(235), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(263), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(268), new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(268) });

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
                columns: new[] { "CreatedDate", "Height", "LastModifiedDate", "Name", "Width" },
                values: new object[] { new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(436), 470, new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(437), "1300X470", 1300 });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "CreatedDate", "Height", "LastModifiedDate", "MediaFormatType", "Name", "Width" },
                values: new object[] { "card", new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(439), 200, new DateTime(2023, 5, 19, 10, 35, 50, 780, DateTimeKind.Utc).AddTicks(440), 3, "400X200", 400 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6192), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6196), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6197), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6366), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6377), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6379), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6385), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6387), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6388), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6389), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6391), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6503), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6505), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6507), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6508), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6510), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6512), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6514), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6516), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6517), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Height", "LastModifiedDate", "Name", "Width" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6519), 540, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6519), "1920x540", 1920 });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "CreatedDate", "Height", "LastModifiedDate", "MediaFormatType", "Name", "Width" },
                values: new object[] { "carousel_front", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6521), 378, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6521), 1, "672x378", 672 });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6478), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6479), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6481), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6482), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6484), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6617), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6619), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6620), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6647), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6605), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6543), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6545), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6547), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6579), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6582), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6585), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6586), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6588), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6554), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6555), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6556) });
        }
    }
}
