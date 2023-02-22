using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
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
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ParentCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DataType = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
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
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gallery",
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
                    table.PrimaryKey("PK_Gallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaFormats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Height = table.Column<int>(type: "integer", nullable: true),
                    Width = table.Column<int>(type: "integer", nullable: true),
                    MediaFormatType = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaFormats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telephone = table.Column<string>(type: "text", nullable: false),
                    Company = table.Column<string>(type: "text", nullable: false),
                    EmployeeName = table.Column<string>(type: "text", nullable: false),
                    TaxNumber = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
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
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Abbreviation = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VariantItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Barcode = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Variants",
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
                    table.PrimaryKey("PK_Variants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassificationAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: true),
                    ClassificationId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificationAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassificationAttributeValues_Classifications_Classificatio~",
                        column: x => x.ClassificationId,
                        principalTable: "Classifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ClassificationId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Classifications_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "Classifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    BannerType = table.Column<int>(type: "integer", nullable: false),
                    GalleryId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banners_Gallery_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Gallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RealFilename = table.Column<string>(type: "text", nullable: false),
                    EncodedFilename = table.Column<string>(type: "text", nullable: false),
                    FilePath = table.Column<string>(type: "text", nullable: false),
                    RootPath = table.Column<string>(type: "text", nullable: false),
                    ServePath = table.Column<string>(type: "text", nullable: false),
                    AbsolutePath = table.Column<string>(type: "text", nullable: false),
                    Mime = table.Column<string>(type: "text", nullable: false),
                    Extension = table.Column<string>(type: "text", nullable: false),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    Secure = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    MediaType = table.Column<int>(type: "integer", nullable: false),
                    MediaFormatId = table.Column<int>(type: "integer", nullable: true),
                    GalleryId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medias_Gallery_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Gallery",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Medias_MediaFormats_MediaFormatId",
                        column: x => x.MediaFormatId,
                        principalTable: "MediaFormats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RolesPermissions",
                columns: table => new
                {
                    PermissionsId = table.Column<int>(type: "integer", nullable: false),
                    RolesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesPermissions", x => new { x.PermissionsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_RolesPermissions_Permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolesPermissions_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    BrandId = table.Column<int>(type: "integer", nullable: false),
                    SupplierId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    District = table.Column<string>(type: "text", nullable: false),
                    Neighbourhood = table.Column<string>(type: "text", nullable: false),
                    FullAddress = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "integer", nullable: false),
                    UsersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GalleriesVariantItems",
                columns: table => new
                {
                    GalleriesId = table.Column<int>(type: "integer", nullable: false),
                    VariantItemsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleriesVariantItems", x => new { x.GalleriesId, x.VariantItemsId });
                    table.ForeignKey(
                        name: "FK_GalleriesVariantItems_Gallery_GalleriesId",
                        column: x => x.GalleriesId,
                        principalTable: "Gallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GalleriesVariantItems_VariantItems_VariantItemsId",
                        column: x => x.VariantItemsId,
                        principalTable: "VariantItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VariantValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    VariantId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VariantValues_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassificationAttributeValuesVariantItems",
                columns: table => new
                {
                    ClassificationAttributeValuesId = table.Column<int>(type: "integer", nullable: false),
                    VariantItemsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificationAttributeValuesVariantItems", x => new { x.ClassificationAttributeValuesId, x.VariantItemsId });
                    table.ForeignKey(
                        name: "FK_ClassificationAttributeValuesVariantItems_ClassificationAtt~",
                        column: x => x.ClassificationAttributeValuesId,
                        principalTable: "ClassificationAttributeValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassificationAttributeValuesVariantItems_VariantItems_Vari~",
                        column: x => x.VariantItemsId,
                        principalTable: "VariantItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassificationAttributeValuesOptions",
                columns: table => new
                {
                    ClassificationAttributeValuesId = table.Column<int>(type: "integer", nullable: false),
                    OptionsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificationAttributeValuesOptions", x => new { x.ClassificationAttributeValuesId, x.OptionsId });
                    table.ForeignKey(
                        name: "FK_ClassificationAttributeValuesOptions_ClassificationAttribut~",
                        column: x => x.ClassificationAttributeValuesId,
                        principalTable: "ClassificationAttributeValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassificationAttributeValuesOptions_Options_OptionsId",
                        column: x => x.OptionsId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GalleryProduct",
                columns: table => new
                {
                    GalleriesId = table.Column<int>(type: "integer", nullable: false),
                    ProductsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryProduct", x => new { x.GalleriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_GalleryProduct_Gallery_GalleriesId",
                        column: x => x.GalleriesId,
                        principalTable: "Gallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GalleryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsCategories",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "integer", nullable: false),
                    ProductsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsCategories", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ProductsCategories_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsCategories_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsClassificationAttributeValues",
                columns: table => new
                {
                    ClassificationAttributeValuesId = table.Column<int>(type: "integer", nullable: false),
                    ProductsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsClassificationAttributeValues", x => new { x.ClassificationAttributeValuesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ProductsClassificationAttributeValues_ClassificationAttribu~",
                        column: x => x.ClassificationAttributeValuesId,
                        principalTable: "ClassificationAttributeValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsClassificationAttributeValues_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsMedias",
                columns: table => new
                {
                    MediasId = table.Column<int>(type: "integer", nullable: false),
                    ProductsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsMedias", x => new { x.MediasId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ProductsMedias_Medias_MediasId",
                        column: x => x.MediasId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsMedias_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsTags",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "integer", nullable: false),
                    TagsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsTags", x => new { x.ProductsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_ProductsTags_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsTags_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsVariantItems",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "integer", nullable: false),
                    VariantItemsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsVariantItems", x => new { x.ProductsId, x.VariantItemsId });
                    table.ForeignKey(
                        name: "FK_ProductsVariantItems_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsVariantItems_VariantItems_VariantItemsId",
                        column: x => x.VariantItemsId,
                        principalTable: "VariantItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsVariants",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "integer", nullable: false),
                    VariantsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsVariants", x => new { x.ProductsId, x.VariantsId });
                    table.ForeignKey(
                        name: "FK_ProductsVariants_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsVariants_Variants_VariantsId",
                        column: x => x.VariantsId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VariantValuesVariantItems",
                columns: table => new
                {
                    VariantItemsId = table.Column<int>(type: "integer", nullable: false),
                    VariantValuesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantValuesVariantItems", x => new { x.VariantItemsId, x.VariantValuesId });
                    table.ForeignKey(
                        name: "FK_VariantValuesVariantItems_VariantItems_VariantItemsId",
                        column: x => x.VariantItemsId,
                        principalTable: "VariantItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VariantValuesVariantItems_VariantValues_VariantValuesId",
                        column: x => x.VariantValuesId,
                        principalTable: "VariantValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Telephone = table.Column<string>(type: "text", nullable: false),
                    OpenAdress = table.Column<string>(type: "text", nullable: false),
                    PostCode = table.Column<string>(type: "text", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    DistrictId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Warehouses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Warehouses_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Code", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "alfa_beta", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6192), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6194), "Alfa Beta" },
                    { 2, "june", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6196), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6196), "June" },
                    { 3, "brooks_brothers", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6197), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6198), "Brooks Brothers" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "LastModifiedDate", "Level", "Name", "ParentCategoryId" },
                values: new object[] { 1, "clothes", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6366), "Giyim", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6366), 1, "Giyim", null });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "Code", "CreatedDate", "DataType", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "gender", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6385), 3, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6386), "Cinsiyet" },
                    { 2, "pattern", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6387), 0, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6387), "Kalıp" },
                    { 3, "stil", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6388), 4, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6389), "Stil" },
                    { 4, "warranty_period", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6389), 1, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6390), "Garanti Süresi" },
                    { 5, "international_sales", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6391), 2, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6391), "Yurt Dışı Satış" }
                });

            migrationBuilder.InsertData(
                table: "MediaFormats",
                columns: new[] { "Id", "Code", "CreatedDate", "Height", "LastModifiedDate", "MediaFormatType", "Name", "Width" },
                values: new object[,]
                {
                    { 1, "icon", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6503), 100, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6503), 0, "100x100", 100 },
                    { 2, "small", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6505), 200, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6505), 0, "200x200", 200 },
                    { 3, "thumbnail", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6507), 300, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6507), 0, "300x300", 300 },
                    { 4, "medium", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6508), 400, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6509), 0, "400x400", 400 },
                    { 5, "big", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6510), 500, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6511), 0, "500x500", 500 },
                    { 6, "huge", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6512), 600, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6512), 0, "600x600", 600 },
                    { 7, "zoom", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6514), 700, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6514), 0, "700x700", 700 },
                    { 8, "superzoom", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6516), 800, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6516), 0, "800x800", 800 },
                    { 9, "original", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6517), null, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6518), 4, "original", null },
                    { 10, "carousel_back", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6519), 540, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6519), 1, "1920x540", 1920 },
                    { 11, "carousel_front", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6521), 378, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6521), 1, "672x378", 672 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "product_created", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6617), "Ürün oluşturmak için gerekli izin", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6617), "Ürün Oluşturma Yetkisi" },
                    { 2, "product_deleted", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6619), "Ürün silmek için gerekli izin", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6619), "Ürün Silme Yetkisi" },
                    { 3, "product_updated", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6620), "Ürün güncelleme için gerekli izin", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6620), "Ürün Güncelleme Yetkisi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "CreatedDate", "IsActive", "LastModifiedDate", "Name" },
                values: new object[] { 1, "admin", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6647), true, new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6647), "admin" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "Code", "Company", "CreatedDate", "Email", "EmployeeName", "LastModifiedDate", "Name", "TaxNumber", "Telephone" },
                values: new object[] { 1, "Atatürk Mah. Orhan Veli Caddesi No:6 34522 Esenyurt İstanbul Türkiye", "supplier_1", "Ozon Tekstil", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6605), "ozontekstil@gmail.com", "Duygu Sivrioğlu", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6606), "Elbise Tedarikçim", "123456789", "0212 886 69 86" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Code", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "new_member_special", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6543), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6544), "Yeni Üyelere Özel" },
                    { 2, "premium_member_special", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6545), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6546), "Premium Üyelere Özel" },
                    { 3, "super_discount", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6547), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6547), "Süper İndirim" }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "Code", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "size", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6554), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6554), "Beden" },
                    { 2, "color", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6555), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6556), "Renk" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "LastModifiedDate", "Level", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 2, "man", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6377), "Erkek", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6378), 1, "Erkek", 1 },
                    { 3, "woman", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6379), "Kadın", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6380), 2, "Kadın", 1 }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "ClassificationId", "Code", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, "male", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6478), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6478), "Erkek" },
                    { 2, 1, "female", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6479), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6480), "Kadın" },
                    { 3, 3, "evening_dresses", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6481), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6481), "Abiye" },
                    { 4, 3, "night", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6482), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6483), "Gece" },
                    { 5, 3, "daily", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6484), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6484), "Günlük" }
                });

            migrationBuilder.InsertData(
                table: "VariantValues",
                columns: new[] { "Id", "Code", "CreatedDate", "LastModifiedDate", "Name", "VariantId" },
                values: new object[,]
                {
                    { 1, "s", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6579), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6580), "S", 1 },
                    { 2, "m", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6582), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6582), "M", 1 },
                    { 3, "l", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6585), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6585), "L", 1 },
                    { 4, "blue", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6586), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6587), "Mavi", 2 },
                    { 5, "black", new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6588), new DateTime(2023, 2, 22, 21, 57, 14, 956, DateTimeKind.Utc).AddTicks(6588), "Siyah", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Banners_GalleryId",
                table: "Banners",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassificationAttributeValues_ClassificationId",
                table: "ClassificationAttributeValues",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassificationAttributeValuesOptions_OptionsId",
                table: "ClassificationAttributeValuesOptions",
                column: "OptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassificationAttributeValuesVariantItems_VariantItemsId",
                table: "ClassificationAttributeValuesVariantItems",
                column: "VariantItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleriesVariantItems_VariantItemsId",
                table: "GalleriesVariantItems",
                column: "VariantItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryProduct_ProductsId",
                table: "GalleryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_GalleryId",
                table: "Medias",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_MediaFormatId",
                table: "Medias",
                column: "MediaFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_ClassificationId",
                table: "Options",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCategories_ProductsId",
                table: "ProductsCategories",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsClassificationAttributeValues_ProductsId",
                table: "ProductsClassificationAttributeValues",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsMedias_ProductsId",
                table: "ProductsMedias",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTags_TagsId",
                table: "ProductsTags",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsVariantItems_VariantItemsId",
                table: "ProductsVariantItems",
                column: "VariantItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsVariants_VariantsId",
                table: "ProductsVariants",
                column: "VariantsId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesPermissions_RolesId",
                table: "RolesPermissions",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UsersId",
                table: "UserRoles",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_VariantValues_VariantId",
                table: "VariantValues",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_VariantValuesVariantItems_VariantValuesId",
                table: "VariantValuesVariantItems",
                column: "VariantValuesId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_CityId",
                table: "Warehouses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_CountryId",
                table: "Warehouses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_DistrictId",
                table: "Warehouses",
                column: "DistrictId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "ClassificationAttributeValuesOptions");

            migrationBuilder.DropTable(
                name: "ClassificationAttributeValuesVariantItems");

            migrationBuilder.DropTable(
                name: "GalleriesVariantItems");

            migrationBuilder.DropTable(
                name: "GalleryProduct");

            migrationBuilder.DropTable(
                name: "ProductsCategories");

            migrationBuilder.DropTable(
                name: "ProductsClassificationAttributeValues");

            migrationBuilder.DropTable(
                name: "ProductsMedias");

            migrationBuilder.DropTable(
                name: "ProductsTags");

            migrationBuilder.DropTable(
                name: "ProductsVariantItems");

            migrationBuilder.DropTable(
                name: "ProductsVariants");

            migrationBuilder.DropTable(
                name: "RolesPermissions");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "VariantValuesVariantItems");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ClassificationAttributeValues");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VariantItems");

            migrationBuilder.DropTable(
                name: "VariantValues");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Classifications");

            migrationBuilder.DropTable(
                name: "Gallery");

            migrationBuilder.DropTable(
                name: "MediaFormats");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Variants");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
