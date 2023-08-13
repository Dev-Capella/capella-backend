using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig123123122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContentCategoryId",
                table: "Medias",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(8924), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(8928), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9100), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9111), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9112), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9117), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9118), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9119), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9120), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9121), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9158), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9159), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9160), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9161), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9162), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9163), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9164), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9165), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9166), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9167), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9168), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9142), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9144), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9145), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9145), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9146), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9270), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9271), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9272), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9286), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9266), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9182), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9183), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9184), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9209), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9212), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9213), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9214), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9189), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 8, 13, 13, 58, 46, 210, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.CreateIndex(
                name: "IX_Medias_ContentCategoryId",
                table: "Medias",
                column: "ContentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_ContentCategories_ContentCategoryId",
                table: "Medias",
                column: "ContentCategoryId",
                principalTable: "ContentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medias_ContentCategories_ContentCategoryId",
                table: "Medias");

            migrationBuilder.DropIndex(
                name: "IX_Medias_ContentCategoryId",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "ContentCategoryId",
                table: "Medias");

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
    }
}
