using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig_2 : Migration
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
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6523), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6527), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6529), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Slug" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6862), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6863), "category-1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Slug" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6886), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6886), "category-2" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Slug" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6889), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6889), "category-3" });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6898), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6902), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6904), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6906), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7003), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7006), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7008), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7011), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7013), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7016), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7018), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7020), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7023), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7025), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "MediaFormats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7028), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6964), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6968), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6970), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6972), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6975), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7189), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7191), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7193), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7241), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7180), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7067), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7070), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7072), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7140), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7143), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7146), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7148), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7150), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7084), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7086), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7087) });
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
