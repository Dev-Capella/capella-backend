using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VariantValues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Code", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "alfa_beta", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6523), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6525), "Alfa Beta" },
                    { 2, "june", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6527), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6528), "June" },
                    { 3, "brooks_brothers", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6529), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6530), "Brooks Brothers" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "LastModifiedDate", "Level", "Name", "ParentCategoryId", "Slug" },
                values: new object[] { 1, "clothes", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6862), "Giyim", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6863), 1, "Giyim", null, "category-1" });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "Code", "CreatedDate", "DataType", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "gender", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6898), 3, new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6899), "Cinsiyet" },
                    { 2, "pattern", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6900), 0, new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6901), "Kalıp" },
                    { 3, "stil", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6902), 4, new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6903), "Stil" },
                    { 4, "warranty_period", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6904), 1, new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6905), "Garanti Süresi" },
                    { 5, "international_sales", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6906), 2, new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6907), "Yurt Dışı Satış" }
                });

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

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "product_created", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7189), "Ürün oluşturmak için gerekli izin", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7190), "Ürün Oluşturma Yetkisi" },
                    { 2, "product_deleted", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7191), "Ürün silmek için gerekli izin", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7192), "Ürün Silme Yetkisi" },
                    { 3, "product_updated", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7193), "Ürün güncelleme için gerekli izin", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7194), "Ürün Güncelleme Yetkisi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "CreatedDate", "IsActive", "LastModifiedDate", "Name" },
                values: new object[] { 1, "admin", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7241), true, new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7241), "admin" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "Code", "Company", "CreatedDate", "Email", "EmployeeName", "LastModifiedDate", "Name", "TaxNumber", "Telephone" },
                values: new object[] { 1, "Atatürk Mah. Orhan Veli Caddesi No:6 34522 Esenyurt İstanbul Türkiye", "supplier_1", "Ozon Tekstil", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7180), "ozontekstil@gmail.com", "Duygu Sivrioğlu", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7181), "Elbise Tedarikçim", "123456789", "0212 886 69 86" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Code", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "new_member_special", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7067), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7067), "Yeni Üyelere Özel" },
                    { 2, "premium_member_special", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7070), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7070), "Premium Üyelere Özel" },
                    { 3, "super_discount", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7072), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7072), "Süper İndirim" }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "Code", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "size", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7084), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7085), "Beden" },
                    { 2, "color", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7086), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7087), "Renk" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "LastModifiedDate", "Level", "Name", "ParentCategoryId", "Slug" },
                values: new object[,]
                {
                    { 2, "man", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6886), "Erkek", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6886), 1, "Erkek", 1, "category-2" },
                    { 3, "woman", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6889), "Kadın", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6889), 2, "Kadın", 1, "category-3" }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "ClassificationId", "Code", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, "male", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6964), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6965), "Erkek" },
                    { 2, 1, "female", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6968), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6969), "Kadın" },
                    { 3, 3, "evening_dresses", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6970), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6971), "Abiye" },
                    { 4, 3, "night", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6972), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6973), "Gece" },
                    { 5, 3, "daily", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6975), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(6975), "Günlük" }
                });

            migrationBuilder.InsertData(
                table: "VariantValues",
                columns: new[] { "Id", "Code", "CreatedDate", "LastModifiedDate", "Name", "VariantId" },
                values: new object[,]
                {
                    { 1, "s", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7140), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7141), "S", 1 },
                    { 2, "m", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7143), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7144), "M", 1 },
                    { 3, "l", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7146), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7147), "L", 1 },
                    { 4, "blue", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7148), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7149), "Mavi", 2 },
                    { 5, "black", new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7150), new DateTime(2023, 7, 15, 13, 58, 53, 200, DateTimeKind.Utc).AddTicks(7151), "Siyah", 2 }
                });
        }
    }
}
