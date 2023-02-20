using Domain.Entities;
using Domain.Entities.Common;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class CapellaDbContext : DbContext
    {
        public CapellaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Classification> Classifications { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<ClassificationAttributeValue> ClassificationAttributeValues { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<MediaFormat> MediaFormats { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<VariantValue> VariantValues { get; set; }
        public DbSet<VariantItem> VariantItems { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Banner> Banners { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var now = DateTime.UtcNow;

            foreach (var changedEntity in ChangeTracker.Entries())
            {
                if (changedEntity.Entity is BaseEntity entity)
                {
                    switch (changedEntity.State)
                    {
                        case EntityState.Added:
                            entity.CreatedDate = now;
                            entity.LastModifiedDate = now;
                            break;

                        case EntityState.Modified:
                            Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                            entity.LastModifiedDate = now;
                            break;
                    }
                }
            }


            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Category>()
                .HasOne(category => category.ParentCategory)
                .WithMany(category => category.SubCategories)
                .HasForeignKey(category => category.ParentCategoryId);

            modelBuilder
                .Entity<Product>()
                .HasOne(product => product.Brand)
                .WithMany(brand => brand.Products);

            modelBuilder
                .Entity<Product>()
                .HasOne(product => product.Supplier)
                .WithMany(supplier => supplier.Products);

            modelBuilder
                .Entity<Product>()
                .HasMany(product => product.Tags)
                .WithMany(tag => tag.Products)
                .UsingEntity(j => j.ToTable("ProductsTags"));

            modelBuilder
                .Entity<Product>()
                .HasMany(product => product.Variants)
                .WithMany(variant => variant.Products)
                .UsingEntity(j => j.ToTable("ProductsVariants"));

            modelBuilder
                .Entity<Product>()
                .HasMany(product => product.VariantItems)
                .WithMany(variantItem => variantItem.Products)
                .UsingEntity(j => j.ToTable("ProductsVariantItems"));

            modelBuilder
                .Entity<Variant>()
                .HasMany(variant => variant.VariantValues)
                .WithOne(variantValue => variantValue.Variant);

            modelBuilder
                .Entity<VariantItem>()
                .HasMany(variantItem => variantItem.VariantValues)
                .WithMany(variantValue => variantValue.VariantItems)
                .UsingEntity(j => j.ToTable("VariantValuesVariantItems"));

            modelBuilder
                .Entity<VariantItem>()
                .HasMany(variantItem => variantItem.ClassificationAttributeValues)
                .WithMany(classificationAttributeValue => classificationAttributeValue.VariantItems)
                .UsingEntity(j => j.ToTable("ClassificationAttributeValuesVariantItems"));

            modelBuilder
                .Entity<VariantItem>()
                .HasMany(variantItem => variantItem.Galleries)
                .WithMany(galllery => galllery.VariantItems)
                .UsingEntity(j => j.ToTable("GalleriesVariantItems"));

            modelBuilder
                .Entity<Product>()
                .HasMany(product => product.Categories)
                .WithMany(category => category.Products)
                .UsingEntity(j => j.ToTable("ProductsCategories"));

            modelBuilder
                .Entity<Classification>()
                .HasMany(c => c.Options)
                .WithOne(o => o.Classification);

            modelBuilder
                .Entity<Product>()
                .HasMany(c => c.ClassificationAttributeValues)
                .WithMany(p => p.Products)
                .UsingEntity(j => j.ToTable("ProductsClassificationAttributeValues"));

            modelBuilder
                .Entity<Banner>()
                .HasOne(b => b.Gallery)
                .WithMany(p => p.Banners);

            modelBuilder
                .Entity<ClassificationAttributeValue>()
                .HasMany(attributeValue => attributeValue.Options)
                .WithMany(option => option.ClassificationAttributeValues)
                .UsingEntity(j => j.ToTable("ClassificationAttributeValuesOptions"));

            modelBuilder
                .Entity<Product>()
                .HasMany(p => p.Medias)
                .WithMany(m => m.Products)
                .UsingEntity(j => j.ToTable("ProductsMedias"));

            modelBuilder
                .Entity<User>()
                .HasMany(user => user.Addresses)
                .WithOne(address => address.User);

            modelBuilder
                .Entity<User>()
                .HasMany(user => user.Roles)
                .WithMany(role => role.Users)
                .UsingEntity(j => j.ToTable("UserRoles"));

            modelBuilder
                .Entity<Role>()
                .HasMany(role => role.Permissions)
                .WithMany(permission => permission.Roles)
                .UsingEntity(crossTable => crossTable.ToTable("RolesPermissions"));

            modelBuilder
                .Entity<Country>()
                .HasMany(country => country.Cities)
                .WithOne(city => city.Country);

            modelBuilder
                .Entity<City>()
                .HasMany(city => city.Districts)
                .WithOne(district => district.City);

            modelBuilder.Entity<Media>()
                .HasOne(m => m.MediaFormat)
                .WithMany(mf => mf.Medias)
                .IsRequired(false);

            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Code = "alfa_beta",
                    Name = "Alfa Beta",
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new Brand
                {
                    Id = 2,
                    Code = "june",
                    Name = "June",
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new Brand
                {
                    Id = 3,
                    Code = "brooks_brothers",
                    Name = "Brooks Brothers",
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                }
            );

            var category1 = new Category
            {
                Id = 1,
                Code = "clothes",
                Name = "Giyim",
                Description = "Giyim",
                ParentCategory = null,
                Level = 1,
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };

            modelBuilder.Entity<Category>().HasData(
                category1,
                new Category
                {
                    Id = 2,
                    Code = "man",
                    Name = "Erkek",
                    Description = "Erkek",
                    ParentCategoryId = 1,
                    Level = 1,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new Category
                {
                    Id = 3,
                    Code = "woman",
                    Name = "Kadın",
                    Description = "Kadın",
                    ParentCategoryId = 1,
                    Level = 2,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                }
            );

            var classification1 = new Classification
            {
                Id = 1,
                Code = "gender",
                Name = "Cinsiyet",
                DataType = DataType.CHOICE,
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };
            var classification2 = new Classification
            {
                Id = 2,
                Code = "pattern",
                Name = "Kalıp",
                DataType = DataType.TEXT,
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };
            var classification3 = new Classification
            {
                Id = 3,
                Code = "stil",
                Name = "Stil",
                DataType = DataType.MULTICHOICE,
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };
            var classification4 = new Classification
            {
                Id = 4,
                Code = "warranty_period",
                Name = "Garanti Süresi",
                DataType = DataType.NUMERIC,
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };
            var classification5 = new Classification
            {
                Id = 5,
                Code = "international_sales",
                Name = "Yurt Dışı Satış",
                DataType = DataType.LOGIC,
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };
            modelBuilder.Entity<Classification>().HasData(
                classification1,
                classification2,
                classification3,
                classification4,
                classification5
            );

            modelBuilder.Entity<Options>().HasData(
                new Options
                {
                    Id = 1,
                    Code = "male",
                    Name = "Erkek",
                    ClassificationId = 1,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new Options
                {
                    Id = 2,
                    Code = "female",
                    Name = "Kadın",
                    ClassificationId = 1,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new Options
                {
                    Id = 3,
                    Code = "evening_dresses",
                    Name = "Abiye",
                    ClassificationId = 3,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new Options
                {
                    Id = 4,
                    Code = "night",
                    Name = "Gece",
                    ClassificationId = 3,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new Options
                {
                    Id = 5,
                    Code = "daily",
                    Name = "Günlük",
                    ClassificationId = 3,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<MediaFormat>().HasData(
                new MediaFormat
                {
                    Id = 1,
                    Code = "icon",
                    Name = "100x100",
                    Height = 100,
                    Width = 100,
                    MediaFormatType = MediaFormatType.PRODUCT,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new MediaFormat
                {
                    Id = 2,
                    Code = "small",
                    Name = "200x200",
                    Height = 200,
                    Width = 200,
                    MediaFormatType = MediaFormatType.PRODUCT,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new MediaFormat
                {
                    Id = 3,
                    Code = "thumbnail",
                    Name = "300x300",
                    Height = 300,
                    Width = 300,
                    MediaFormatType = MediaFormatType.PRODUCT,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new MediaFormat
                {
                    Id = 4,
                    Code = "medium",
                    Name = "400x400",
                    Height = 400,
                    Width = 400,
                    MediaFormatType = MediaFormatType.PRODUCT,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new MediaFormat
                {
                    Id = 5,
                    Code = "big",
                    Name = "500x500",
                    Height = 500,
                    Width = 500,
                    MediaFormatType = MediaFormatType.PRODUCT, CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new MediaFormat
                {
                    Id = 6,
                    Code = "huge",
                    Name = "600x600",
                    Height = 600,
                    Width = 600,
                    MediaFormatType = MediaFormatType.PRODUCT,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new MediaFormat
                {
                    Id = 7,
                    Code = "zoom",
                    Name = "700x700",
                    Height = 700,
                    Width = 700,
                    MediaFormatType = MediaFormatType.PRODUCT,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new MediaFormat
                {
                    Id = 8,
                    Code = "superzoom",
                    Name = "800x800",
                    Height = 800,
                    Width = 800,
                    MediaFormatType = MediaFormatType.PRODUCT,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new MediaFormat
                {
                    Id = 9,
                    Code = "original",
                    Name = "original",
                    Height = null,
                    Width = null,
                    MediaFormatType = MediaFormatType.ALL,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new MediaFormat
                {
                    Id = 10,
                    Code = "carousel_back",
                    Name = "1920x540",
                    Height = 540,
                    Width = 1920,
                    MediaFormatType = MediaFormatType.CAROUSELBANNER,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new MediaFormat
                {
                    Id = 11,
                    Code = "carousel_front",
                    Name = "672x378",
                    Height = 378,
                    Width = 672,
                    MediaFormatType = MediaFormatType.CAROUSELBANNER,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    Id = 1,
                    Code = "new_member_special",
                    Name = "Yeni Üyelere Özel",
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new Tag
                {
                    Id = 2,
                    Code = "premium_member_special",
                    Name = "Premium Üyelere Özel",
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new Tag
                {
                    Id = 3,
                    Code = "super_discount",
                    Name = "Süper İndirim",
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                }
            );


            var variant1 = new Variant
            {
                Id = 1,
                Code = "size",
                Name = "Beden",
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };
            var variant2 = new Variant
            {
                Id = 2,
                Code = "color",
                Name = "Renk",
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };
            modelBuilder.Entity<Variant>().HasData(
                variant1,
                variant2
            );

            modelBuilder.Entity<VariantValue>().HasData(
                new VariantValue
                {
                    Id = 1,
                    Code = "s",
                    Name = "S",
                    VariantId = 1,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new VariantValue
                {
                    Id = 2,
                    Code = "m",
                    Name = "M",
                    VariantId = 1,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new VariantValue
                {
                    Id = 3,
                    Code = "l",
                    Name = "L",
                    VariantId = 1,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new VariantValue
                {
                    Id = 4,
                    Code = "blue",
                    Name = "Mavi",
                    VariantId = 2,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new VariantValue
                {
                    Id = 5,
                    Code = "black",
                    Name = "Siyah",
                    VariantId = 2,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    Id = 1,
                    Code = "supplier_1",
                    Name = "Elbise Tedarikçim",
                    Email = "ozontekstil@gmail.com",
                    Company = "Ozon Tekstil",
                    EmployeeName = "Duygu Sivrioğlu",
                    Address = "Atatürk Mah. Orhan Veli Caddesi No:6 34522 Esenyurt İstanbul Türkiye",
                    Telephone = "0212 886 69 86",
                    TaxNumber = "123456789",
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                }
            );

            var permission1 = new Permission
            {
                Id = 1,
                Code = "product_created",
                Name = "Ürün Oluşturma Yetkisi",
                Description = "Ürün oluşturmak için gerekli izin",
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };
            var permission2 = new Permission
            {
                Id = 2,
                Code = "product_deleted",
                Name = "Ürün Silme Yetkisi",
                Description = "Ürün silmek için gerekli izin",
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };
            var permission3 = new Permission
            {
                Id = 3,
                Code = "product_updated",
                Name = "Ürün Güncelleme Yetkisi",
                Description = "Ürün güncelleme için gerekli izin",
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow
            };
            modelBuilder.Entity<Permission>().HasData(
                permission1,
                permission2,
                permission3
            );

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Code = "admin",
                    Name = "admin",
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow,
                    
                }
            );
        }
    }
}