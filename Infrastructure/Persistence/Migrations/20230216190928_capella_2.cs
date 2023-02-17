using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class capella_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BannersGalleries");

            migrationBuilder.AlterColumn<int>(
                name: "Width",
                table: "MediaFormats",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "MediaFormats",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "GalleryId",
                table: "Banners",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Banners_GalleryId",
                table: "Banners",
                column: "GalleryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Banners_Gallery_GalleryId",
                table: "Banners",
                column: "GalleryId",
                principalTable: "Gallery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banners_Gallery_GalleryId",
                table: "Banners");

            migrationBuilder.DropIndex(
                name: "IX_Banners_GalleryId",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "GalleryId",
                table: "Banners");

            migrationBuilder.AlterColumn<int>(
                name: "Width",
                table: "MediaFormats",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "MediaFormats",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BannersGalleries",
                columns: table => new
                {
                    BannersId = table.Column<int>(type: "integer", nullable: false),
                    GalleriesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannersGalleries", x => new { x.BannersId, x.GalleriesId });
                    table.ForeignKey(
                        name: "FK_BannersGalleries_Banners_BannersId",
                        column: x => x.BannersId,
                        principalTable: "Banners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BannersGalleries_Gallery_GalleriesId",
                        column: x => x.GalleriesId,
                        principalTable: "Gallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BannersGalleries_GalleriesId",
                table: "BannersGalleries",
                column: "GalleriesId");
        }
    }
}
