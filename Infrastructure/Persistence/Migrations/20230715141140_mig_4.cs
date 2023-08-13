using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2460), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2464), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2466), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2468), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2470), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2472), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2473), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2475), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2477), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2478), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2480), new DateTime(2023, 7, 15, 14, 11, 39, 698, DateTimeKind.Utc).AddTicks(2481) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1108), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1114), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1116), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1118), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1120), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1122), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1124), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1126), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1127), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1129), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1131), new DateTime(2023, 7, 15, 14, 10, 7, 932, DateTimeKind.Utc).AddTicks(1131) });
        }
    }
}
